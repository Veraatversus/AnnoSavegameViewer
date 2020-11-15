namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class CityLayout {

		[BinaryContent(Name = "BlockCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString BlockCount { get; set; }

		[BinaryContent(Name = "Block", NodeType = BinaryContentTypes.Node)]
		public CityLayoutBlock Block { get; set; }

	}
}
