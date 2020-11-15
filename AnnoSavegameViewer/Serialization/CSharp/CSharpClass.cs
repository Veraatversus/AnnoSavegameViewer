namespace AnnoSavegameViewer.Serialization.CSharp {
  using AnnoSavegameViewer.Serialization.Pattern;
  using System.Collections.Generic;
  using System.Text;

  public class CSharpClass {

    #region Public Properties

    public string Namespace { get; set; }
    public List<string> Inheritances { get;} = new List<string>();
    public HashSet<string> Usings { get; } = new HashSet<string>();
    public string Name { get; set; }
    public List<CSharpProperty> Propertys { get; } = new List<CSharpProperty>();
    public PropertyPattern Pattern { get; set; }

    #endregion Public Properties

    #region Public Methods

    public override string ToString() {
      var sb = new StringBuilder();

      //Usings
      foreach (var use in Usings) {
        _ = sb.Append("using ").Append(use).AppendLine(";");
      }
      _ = sb.AppendLine("");

      //Namespace
      _ = sb.Append("namespace ").Append(Namespace).AppendLine(" {").AppendLine("");

      //Class Decoration
      _ = sb.Append("public partial class ").Append(Name);

      //Inheritances
      if (Inheritances.Count > 0) {
        _ = sb.Append(" : ");
        for (var i = 0; i < Inheritances.Count; i++) {
          if (i > 0) {
            _ = sb.Append(", ");
          }
          _ = sb.Append(Inheritances[i]);
        }
      }
      _ = sb.AppendLine(" {").AppendLine("");

      //Propertys
      foreach (var property in Propertys) {
        _ = sb.AppendLine(property.ToString(Name)).AppendLine("");
      }

      //Closings
      _ = sb.AppendLine("}");
      _ = sb.AppendLine("}");

      return sb.ToString();
    }

    #endregion Public Methods
  }
}