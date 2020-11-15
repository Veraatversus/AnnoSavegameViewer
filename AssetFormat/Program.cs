namespace AssetFormat {
  using System;
  using System.Collections.Generic;
  using System.Xml.Linq;
  using System.Xml.XPath;

  public static class Program {
    private static void Main(string[] _) {
      Assets.Init();

      ProcessingAssets();
    }

    private static void ProcessingAssets() {
      Console.WriteLine("Processing Assets");
      var result = new XElement("Assets");
      var assets = Assets.Original.Descendants("Asset");
      foreach (var asset in assets) {
        if (asset.Element("Template")?.Value is string template) {
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
