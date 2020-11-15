namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Shipyard {

		[BinaryContent(Name = "ConstructionQueue", NodeType = BinaryContentTypes.Node)]
		public ConstructionQueue ConstructionQueue { get; set; }

		[BinaryContent(Name = "RallyPoint", NodeType = BinaryContentTypes.Attribute)]
		public HexString RallyPoint { get; set; }

	}
}
