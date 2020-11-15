namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class SetupRawMaterial {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public SetupRawMaterialValue Value { get; set; }

	}
}
