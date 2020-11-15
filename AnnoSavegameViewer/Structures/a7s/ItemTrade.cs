namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ItemTrade {

		[BinaryContent(Name = "Items", NodeType = BinaryContentTypes.Node)]
		public Items Items { get; set; }

		[BinaryContent(Name = "LastReroll", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastReroll { get; set; }

	}
}
