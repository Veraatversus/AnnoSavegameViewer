namespace AnnoSavegameViewer.Serialization.CSharp {
  using AnnoSavegameViewer.Serialization.Core;
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
      _ = sb.AppendLine(Attribute.ToAttributeDecorationString());
      _ = sb.Append("public ").Append(Type).Append(' ').Append(name).Append(" { get; set; }");
			return sb.ToString();
		}

		#endregion Public Methods
	}
}