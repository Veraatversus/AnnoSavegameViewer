using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Xml.XPath;

namespace AssetFormat {
  public static class Program {
    static void Main(string[] args) {
      Assets.Init();

      ProcessingAssets();
    }

    private static void ProcessingAssets() {
      Console.WriteLine("Processing Assets");
      var result = new XElement("Assets");
      var assets = Assets.Original.Descendants("Asset");
      foreach (var asset in assets) {
        if (asset.Element("Template")?.Value is String template) {
          var xNode = new XElement("Asset");
          xNode.Add(new XAttribute("GUID", asset.XPathSelectElement("Values/Standard/GUID").Value));
          xNode.Add(new XAttribute("Template",template ));
          result.Add(xNode);
        }
        
      }
      result.Save($@"{Assets.PathViewer}\Resources\Assets\Assets.xml", SaveOptions.DisableFormatting);
    }
  }
}
