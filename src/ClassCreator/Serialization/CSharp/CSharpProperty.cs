// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace ClassCreator.Serialization.CSharp {
  using AnnoSerializer.Serialization.Core;
  using System.Text;

  public class CSharpProperty {

		#region Public Properties

		public string Name { get; set; }
		public string Type { get; set; }
		public BinaryContentAttribute Attribute { get; set; }

    #endregion Public Properties

    #region Public Methods

    public override string ToString() => ToString(Name);

    public string ToString(string ClassName) {
			var name = Name.UppercaseFirst().Replace(" ", "_", System.StringComparison.Ordinal);
			if (name == ClassName) {
				name += "Item";
			}
			var sb = new StringBuilder();
      _ = sb.Append("\t\t").AppendLine(Attribute.ToAttributeDecorationString());
      _ = sb.Append("\t\tpublic ").Append(Type).Append(' ').Append(name).Append(" { get; set; }");
			return sb.ToString();
		}

		#endregion Public Methods
	}
}