// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace ClassCreator.Serialization.CSharp {
  using ClassCreator.Serialization.Pattern;
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

      //Namespace
      _ = sb.Append("namespace ").Append(Namespace).AppendLine(" {").AppendLine("");

      //Usings
      foreach (var use in Usings) {
        _ = sb.Append("\tusing ").Append(use).AppendLine(";");
      }
      _ = sb.AppendLine("");

      //Class Decoration
      _ = sb.Append("\tpublic partial class ").Append(Name);

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
      _ = sb.AppendLine("\t}");
      _ = sb.AppendLine("}");

      return sb.ToString();
    }

    #endregion Public Methods
  }
}