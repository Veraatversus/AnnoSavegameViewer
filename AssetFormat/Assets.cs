using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using System.Xml.XPath;

namespace AssetFormat {

  internal static class Assets {

    #region Public Constructors

    static Assets() {
      PathRoot = new DirectoryInfo(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace(@"file:\", String.Empty)).Parent.Parent.Parent.FullName;
      PathViewer = new DirectoryInfo(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace(@"file:\", String.Empty)).Parent.Parent.Parent.Parent.FullName + @"\AnnoSavegameViewer";
    }

    #endregion Public Constructors

    #region Public Methods

    public static void Init() {
      Console.WriteLine("Load Asset.xml");
      Original = XmlLoader.LoadXml(PathRoot + @"\Ressources\Anno\assets.xml");
      SolveXmlInheritance();
    }

    #endregion Public Methods

    #region Internal Fields

    internal readonly static String PathRoot;

    internal readonly static String PathViewer;
    internal static XElement Original;

    #endregion Internal Fields

    #region Private Methods

    private static void SolveXmlInheritance() {
      Console.WriteLine("Solve Xml Inheritance");
      var InheritHelper = Original.Descendants("Asset").OrderBy(a => a.InheritDepth()).ToArray();
      foreach (var item in InheritHelper) {
        var baseGuid = item.Element("BaseAssetGUID")?.Value;
        if (baseGuid != null) {
          var baseAsset = Original.Descendants("Asset").FirstOrDefault(a => a.XPathSelectElement("Values/Standard/GUID")?.Value == baseGuid);
          if (baseAsset != null) {
            item.AddStandardValues(baseAsset);
          }
        }
      }
    }

    private static int InheritDepth(this XElement ele) {
      int depth = 0;
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

    #endregion Private Methods
  }
}