// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class CityLayoutBlock {

		[BinaryContent(Name = "Rect", NodeType = BinaryContentTypes.Attribute)]
		public HexString Rect { get; set; }

		[BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ID { get; set; }

		[BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Node)]
		public BlockType Type { get; set; }

		[BinaryContent(Name = "BlockedTiles", NodeType = BinaryContentTypes.Attribute)]
		public HexString BlockedTiles { get; set; }

		[BinaryContent(Name = "RegularBuildings", NodeType = BinaryContentTypes.Node)]
		public RegularBuildings RegularBuildings { get; set; }

		[BinaryContent(Name = "ModulesAndOrnaments", NodeType = BinaryContentTypes.Node)]
		public ModulesAndOrnaments ModulesAndOrnaments { get; set; }

		[BinaryContent(Name = "AllStreetsFinalized", NodeType = BinaryContentTypes.Attribute)]
		public HexString AllStreetsFinalized { get; set; }

		[BinaryContent(Name = "OneStreetFinalized", NodeType = BinaryContentTypes.Attribute)]
		public HexString OneStreetFinalized { get; set; }

		[BinaryContent(Name = "ContainsNonOrnamentals", NodeType = BinaryContentTypes.Attribute)]
		public HexString ContainsNonOrnamentals { get; set; }

		[BinaryContent(Name = "NeededPublic", NodeType = BinaryContentTypes.Node)]
		public NeededPublic NeededPublic { get; set; }

		[BinaryContent(Name = "ProvidedPublic", NodeType = BinaryContentTypes.Node)]
		public ProvidedPublic ProvidedPublic { get; set; }

		[BinaryContent(Name = "ReferencePos", NodeType = BinaryContentTypes.Attribute)]
		public HexString ReferencePos { get; set; }

		[BinaryContent(Name = "MaxCivLevel", NodeType = BinaryContentTypes.Attribute)]
		public HexString MaxCivLevel { get; set; }

	}
}
