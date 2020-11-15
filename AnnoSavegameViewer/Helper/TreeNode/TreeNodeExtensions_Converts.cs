using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using MemoryExtensions = AnnoSavegameViewer.Serialization.Memory.MemoryExtensions;

namespace AnnoSavegameViewer.Helper.TreeNode {

  public static partial class TreeNodeExtensions {

    #region Public Methods

    public static void ExtractAllInformations(this TreeNode node, string saveName) {
      node.SaveXmls(saveName);
      node.SaveCsharpClasses(saveName);
    }

    public static XElement ToXml(this TreeNode node) {
      var element = new XElement(node.Name.Replace(" ", "_"));
      if (!node.Content.IsEmpty) {
        element.Value = MemoryExtensions.ToHexString(node.Content);
        return element;
      }
      if (node.Attributes.Count > 0) {
        var attributes = new XElement("Attributes");
        element.Add(attributes);
        foreach (var item in node.Attributes) {
          attributes.Add(item.ToXml());
        }
      }
      if (node.Nodes.Count > 0) {
        foreach (var item in node.Nodes) {
          element.Add(item.ToXml());
        }
      }

      return element;
    }

    public static IEnumerable<(string Name, string Text)> ToCSharpClasses(this TreeNode node, bool clearUsedNames = true) {
      if (clearUsedNames) {
        UsedClassNames.Clear();
      }

      var className = node.Name.UppercaseFirst().Replace(" ", "_");

      var parentNode = node.Parent;
      while (UsedClassNames.Contains(className.ToLower())) {
        className = parentNode.Name.UppercaseFirst() + className;
        parentNode = parentNode.Parent;
      }
      UsedClassNames.Add(className.ToLower());

      //Write file header
      var stringBuilder = new StringBuilder();
      stringBuilder.Append("using AnnoSavegameViewer.Serialization.Core;");
      stringBuilder.Append(Environment.NewLine);
      stringBuilder.Append("using System.Collections.Generic;");
      stringBuilder.Append(Environment.NewLine);
      stringBuilder.Append(Environment.NewLine);
      stringBuilder.Append("namespace AnnoSavegameViewer.Structures.Savegame.Generated {");
      stringBuilder.Append(Environment.NewLine);
      stringBuilder.Append(Environment.NewLine);
      stringBuilder.Append("public class ");
      stringBuilder.Append(className);
      stringBuilder.Append(" {");
      stringBuilder.Append(Environment.NewLine);
      stringBuilder.Append(Environment.NewLine);

      //Write attributes
      foreach (var attribute in node.Attributes.ToLookup(a => a.Name)) {
        const string fieldType = "object";
        var fieldName = attribute.Key.UppercaseFirst().Replace(" ", "_");
        if (fieldName == className) {
          fieldName += "Item";
        }

        //Write Property Attribute
        stringBuilder.Append("[BinaryContent(Name = \"");
        stringBuilder.Append(attribute.Key);
        stringBuilder.Append("\", NodeType = BinaryContentTypes.Attribute)]");
        stringBuilder.Append(Environment.NewLine);
        stringBuilder.Append("public ");

        //Array Type
        if (attribute.Any(a => a.IsArrayItem)) {
          stringBuilder.Append("List<");
          stringBuilder.Append(fieldType);
          stringBuilder.Append(">");
        }
        else {
          stringBuilder.Append(fieldType);
        }

        //Write end of property
        stringBuilder.Append(" ");
        stringBuilder.Append(fieldName);
        stringBuilder.Append(" { get; set; }");
        stringBuilder.Append(Environment.NewLine);
        stringBuilder.Append(Environment.NewLine);
      }

      //Write nodes
      foreach (var property in node.Nodes.ToLookup(a => a.Name)) {
        var subClassName = property.Key == "None" ? (className.UppercaseFirst() + "List") : property.Key.UppercaseFirst().Replace(" ", "_");

        //Find unique name
        parentNode = node.Parent;
        if (UsedClassNames.Contains(subClassName.ToLower())) {
          subClassName = className.UppercaseFirst() + subClassName;
        }

        while (UsedClassNames.Contains(subClassName.ToLower())) {
          subClassName = parentNode.Name.UppercaseFirst() + subClassName;
          parentNode = parentNode?.Parent;
        }

        //Write Property Attribute
        stringBuilder.Append("[BinaryContent(Name = \"");
        stringBuilder.Append(property.Key);
        stringBuilder.Append("\", NodeType = BinaryContentTypes.Node)]");
        stringBuilder.Append(Environment.NewLine);

        //Write Property
        var type = node.Name;
        stringBuilder.Append("public ");

        var newNode = new TreeNode { Name = subClassName, Parent = node };

        //Array Type
        if (property.Any(p => p.IsArrayItem)) {
          stringBuilder.Append("List<");
          stringBuilder.Append(subClassName);
          stringBuilder.Append(">");
        }
        else {
          stringBuilder.Append(subClassName);
        }

        foreach (var item in property.SelectMany(n => { n.SetArrayItems(); return n.Nodes; })) {
          newNode.AddChild(item);
        }
        foreach (var item in property.SelectMany(n => { n.SetArrayItems(); return n.Attributes; })) {
          newNode.AddAttribute(item);
        }

        //Create Sub Classes
        foreach (var CsClass in newNode.ToCSharpClasses(false)) {
          yield return CsClass;
        }

        //Write end of property
        stringBuilder.Append(" ");
        stringBuilder.Append(property.Key == "None" ? (className.UppercaseFirst() + "List") : property.Key.UppercaseFirst().Replace(" ", "_"));
        stringBuilder.Append(" { get; set; }");
        stringBuilder.Append(Environment.NewLine);
        stringBuilder.Append(Environment.NewLine);
      }

      //Write end of file
      stringBuilder.Append("}");
      stringBuilder.Append(Environment.NewLine);
      stringBuilder.Append("}");

      yield return (className, stringBuilder.ToString());
    }

    public static void SaveXmls(this TreeNode node, string saveName) {
      Directory.CreateDirectory(saveName);
      Directory.CreateDirectory($"{saveName}/Xml");
      //Extract Xmls
      //var sessioncount = 0;
      var rootxml = node.ToXml();
      rootxml.Save($"{saveName}/Xml/{saveName}.data.xml");
      //foreach (var item in node["MetaGameManager"][0]["GameSessions"][0]) {
      //  var xml = item.ToXml();
      //  xml.Save($"{saveName}/Xml/{saveName}.Session{sessioncount++}.xml");
      //}
    }

    public static void SaveCsharpClasses(this TreeNode node, string saveName) {
      Directory.CreateDirectory(saveName);
      Directory.CreateDirectory($"{saveName}/Classes");
      foreach (var item in node.ToCSharpClasses()) {
        var filename = $"{saveName}/Classes/{item.Name}.cs";
        SplitGeneratedClasses(item, saveName);
      }
    }

    public static void ExtractEditedClasses() {
      Directory.CreateDirectory("../../../Structures/Savegame/Generated/Edited");
      foreach (var file in Directory.GetFiles("../../../Structures/Savegame/Generated/Content").ToArray()) {
        var text = File.ReadAllText(file);
        var countAttributes = AttributeRegex.Matches(text).Count;
        var countObjects = ObjectRegex.Matches(text).Count;
        var countLists = ListObjectRegex.Matches(text).Count;
        if (countAttributes != countObjects + countLists) {
          var newFilename = "../../../Structures/Savegame/Generated/Edited/" + Path.GetFileName(file);
          File.Move(file, newFilename);
        }
      }
    }

    #endregion Public Methods

    #region Private Methods

    private static string UppercaseFirst(this string s) {
      if (string.IsNullOrEmpty(s)) {
        return string.Empty;
      }
      char[] a = s.ToCharArray();
      a[0] = char.ToUpper(a[0]);
      return new string(a);
    }

    private static void SplitGeneratedClasses((string Name, string Text) value, string saveName) {
      Directory.CreateDirectory(saveName);
      Directory.CreateDirectory($"{saveName}/Classes");
      Directory.CreateDirectory($"{saveName}/Classes/Empty");
      Directory.CreateDirectory($"{saveName}/Classes/Content");
      Directory.CreateDirectory($"{saveName}/Classes/NoContent");
      if (value.Text.Contains("object")) {
        File.WriteAllText($"{saveName}/Classes/Content/{value.Name}.cs", value.Text);
      }
      else if (value.Text.Contains("get;")) {
        File.WriteAllText($"{saveName}/Classes/NoContent/{value.Name}.cs", value.Text);
      }
      else {
        File.WriteAllText($"{saveName}/Classes/Empty/{value.Name}.cs", value.Text);
      }
    }

    private static IEnumerable<TreeNode> SetArrayItems(this IEnumerable<TreeNode> input) {
      var lookup = input.ToLookup(n => n.Name);
      foreach (var item in lookup.Where(g => g.Count() > 1).SelectMany(g => g)) {
        item.IsArrayItem = true;
      }
      return lookup.SelectMany(g => g);
    }

    #endregion Private Methods

    #region Private Fields

    private static readonly HashSet<string> UsedClassNames = new HashSet<string>();

    private static Regex AttributeRegex = new Regex("BinaryContentType.Attribute");

    private static Regex ObjectRegex = new Regex("public object");
    private static Regex ListObjectRegex = new Regex("public List<object>");

    #endregion Private Fields
  }
}