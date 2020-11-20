// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class Island {

		[BinaryContent(Name = "AreaLayout", NodeType = BinaryContentTypes.Node)]
		public AreaLayout AreaLayout { get; set; }

		[BinaryContent(Name = "OwnedBuildings", NodeType = BinaryContentTypes.Node)]
		public OwnedBuildings OwnedBuildings { get; set; }

		[BinaryContent(Name = "ResourceBalance", NodeType = BinaryContentTypes.Node)]
		public ResourceBalance ResourceBalance { get; set; }

		[BinaryContent(Name = "CityHandler", NodeType = BinaryContentTypes.Node)]
		public CityHandler CityHandler { get; set; }

		[BinaryContent(Name = "HarborHandler", NodeType = BinaryContentTypes.Node)]
		public HarborHandler HarborHandler { get; set; }

		[BinaryContent(Name = "ResourceSatisfaction", NodeType = BinaryContentTypes.Node)]
		public ResourceSatisfaction ResourceSatisfaction { get; set; }

		[BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
		public HexString AreaID { get; set; }

		[BinaryContent(Name = "TileCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString TileCount { get; set; }

		[BinaryContent(Name = "SettleApproach", NodeType = BinaryContentTypes.Node)]
		public SettleApproach SettleApproach { get; set; }

		[BinaryContent(Name = "KontorObject", NodeType = BinaryContentTypes.Attribute)]
		public HexString KontorObject { get; set; }

		[BinaryContent(Name = "KontorPos", NodeType = BinaryContentTypes.Attribute)]
		public HexString KontorPos { get; set; }

		[BinaryContent(Name = "IslandRoles", NodeType = BinaryContentTypes.Attribute)]
		public HexString IslandRoles { get; set; }

		[BinaryContent(Name = "DistanceApprox", NodeType = BinaryContentTypes.Node)]
		public DistanceApprox DistanceApprox { get; set; }

	}
}
