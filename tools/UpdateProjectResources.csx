#r "System.Xml.XDocument"
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using System.Xml.XPath;

const string resPath = "..\\res\\AnnoFiles\\";
const string textPathSerializer = "..\\src\\AnnoSerializer\\Resources\\Languages\\";
Assets.Init();
ProcessingAssets();

private static void ProcessingAssets() {
  var AssetTemplates = new Dictionary<string, string>();
  Console.WriteLine("Processing Assets");
  var assets = Assets.Original.Descendants("Asset");
  foreach (var asset in assets) {
    if (asset.Element("Template")?.Value is string template && asset.XPathSelectElement("Values/Standard/GUID")?.Value is string guid) {
      AssetTemplates.Add(guid, template);
    }
  }

  Dictionary<string, string> TextDictionary = new Dictionary<string, string>();

  foreach (var file in new DirectoryInfo(resPath).GetFiles("texts_*")) {
    Console.Write($"Processing file: {file.Name} ...");
    TextDictionary.Clear();
    var xDoc = XDocument.Load(file.FullName);

    foreach (var text in xDoc.Root.Element("Texts").Elements()) {
      TextDictionary.Add(text.Element("GUID").Value, text.Element("Text").Value);
    }

    var textarray = new XElement("Texts");
    var newXDoc = new XDocument(new XElement("TextExport", textarray));
    string value = null;
    foreach (var item in TextDictionary.Keys.Union(AssetTemplates.Keys)) {
      var check = TextDictionary.TryGetValue(item, out value) || AssetTemplates.TryGetValue(item, out value);
      textarray.Add(new XElement("Text", new XElement("GUID", item), new XElement("Text", value)));
    }

    newXDoc.Save(Path.Combine(textPathSerializer, file.Name), SaveOptions.DisableFormatting);
    Console.WriteLine("Done.");
  }
}

public static class Assets {

  #region Public Properties

  public static XElement Original { get; set; }

  #endregion Public Properties

  #region Public Methods

  public static void Init() {
    Console.WriteLine("Load Asset.xml");
    Original = XmlLoader.LoadXml(Path.Combine(resPath, "assets.xml"));
    SolveXmlInheritance();
  }

  #endregion Public Methods

  private static void SolveXmlInheritance() {
    Console.WriteLine("Solve Xml Inheritance");
    var InheritHelper = Original.Descendants("Asset").OrderBy(a => InheritDepth(a)).ToArray();
    foreach (var item in InheritHelper) {
      var baseGuid = item.Element("BaseAssetGUID")?.Value;
      if (baseGuid != null) {
        var baseAsset = Original.Descendants("Asset").FirstOrDefault(a => a.XPathSelectElement("Values/Standard/GUID")?.Value == baseGuid);
        if (baseAsset != null) {
          XmlLoader.AddStandardValues(item, baseAsset);
        }
      }
    }
  }

  private static int InheritDepth(XElement ele) {
    var depth = 0;
    var search = ele.Element("BaseAssetGUID")?.Value;
    while (search != null) {
      var founded = Original.Descendants("Asset").FirstOrDefault(a => a.XPathSelectElement("Values/Standard/GUID")?.Value == search);
      if (founded != null) {
        depth++;
        search = founded.Element("BaseAssetGUID")?.Value;
      }
    }
    return depth;
  }
}

public static class XmlLoader {

  #region Public Methods

  public static XElement LoadXml(string path) {
    if (File.Exists(path)) {
      var root = XDocument.Load(path).Root;
      var files = new DirectoryInfo(Path.GetDirectoryName(path));
      if (files.EnumerateFiles().FirstOrDefault(f => f.Name == "templates.xml") is FileInfo info) {
        var templates = XDocument.Load(info.FullName).Root.Descendants("Template").ToLookup(t => t.Element("Name")?.Value ?? "trash");
        foreach (var asset in root.Descendants("Asset")) {
          if (templates.Contains(asset.Element("Template")?.Value ?? "")) {
            var standards = templates[asset.Element("Template").Value];
            foreach (var standard in standards) {
             AddStandardValues(asset.Element("Values"), standard.Element("Properties"));
            }
          }
        }
      }
      return root;
    }
    return null;
  }

  public static void AddStandardValues(XElement asset, XElement standarts) {
    foreach (var group in standarts.Elements().GroupBy(e => e.Name.LocalName)) {
      var groupArray = group.ToArray();
      for (var i = 0; i < groupArray.Length; i++) {
        var property = groupArray[i];
        if (asset.Elements(group.Key).Count() > i && asset.Elements(property.Name.LocalName).ElementAt(i) is XElement current) {
          if (property.HasElements) {
            AddStandardValues(current, property);
          }
        }
        else {
          asset.Add(property);
        }
      }
    }
  }

  #endregion Public Methods
}