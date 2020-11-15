namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ProductionLayoutBlock {

		[BinaryContent(Name = "Rect", NodeType = BinaryContentTypes.Attribute)]
		public HexString Rect { get; set; }

		[BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ID { get; set; }

		[BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Node)]
		public ProductionLayoutBlockType Type { get; set; }

		[BinaryContent(Name = "BlockedTiles", NodeType = BinaryContentTypes.Attribute)]
		public HexString BlockedTiles { get; set; }

		[BinaryContent(Name = "RegularBuildings", NodeType = BinaryContentTypes.Node)]
		public BlockRegularBuildings RegularBuildings { get; set; }

		[BinaryContent(Name = "ModulesAndOrnaments", NodeType = BinaryContentTypes.Node)]
		public BlockModulesAndOrnaments ModulesAndOrnaments { get; set; }

		[BinaryContent(Name = "AllStreetsFinalized", NodeType = BinaryContentTypes.Attribute)]
		public HexString AllStreetsFinalized { get; set; }

		[BinaryContent(Name = "ContainsNonOrnamentals", NodeType = BinaryContentTypes.Attribute)]
		public HexString ContainsNonOrnamentals { get; set; }

		[BinaryContent(Name = "BlacklistedGUIDs", NodeType = BinaryContentTypes.Node)]
		public BlacklistedGUIDs BlacklistedGUIDs { get; set; }

		[BinaryContent(Name = "ProductionGUIDs", NodeType = BinaryContentTypes.Node)]
		public ProductionGUIDs ProductionGUIDs { get; set; }

		[BinaryContent(Name = "OneStreetFinalized", NodeType = BinaryContentTypes.Attribute)]
		public HexString OneStreetFinalized { get; set; }

	}
}
