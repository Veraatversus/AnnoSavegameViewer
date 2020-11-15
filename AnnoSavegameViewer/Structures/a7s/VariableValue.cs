namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class VariableValue {

		[BinaryContent(Name = "FloatValue", NodeType = BinaryContentTypes.Node)]
		public FloatValue FloatValue { get; set; }

		[BinaryContent(Name = "Variable", NodeType = BinaryContentTypes.Node)]
		public VariableValueVariable Variable { get; set; }

	}
}
