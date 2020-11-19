// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class ResourceBalance {

		[BinaryContent(Name = "OwnedGoods", NodeType = BinaryContentTypes.Node)]
		public OwnedGoods OwnedGoods { get; set; }

		[BinaryContent(Name = "EstimatedConstructionGoods", NodeType = BinaryContentTypes.Node)]
		public EstimatedConstructionGoods EstimatedConstructionGoods { get; set; }

		[BinaryContent(Name = "ConstructionMaterialUnlocks", NodeType = BinaryContentTypes.Node)]
		public ConstructionMaterialUnlocks ConstructionMaterialUnlocks { get; set; }

		[BinaryContent(Name = "AreaNeedUnlocks", NodeType = BinaryContentTypes.Node)]
		public AreaNeedUnlocks AreaNeedUnlocks { get; set; }

		[BinaryContent(Name = "Balance", NodeType = BinaryContentTypes.Node)]
		public ResourceBalanceBalance Balance { get; set; }

		[BinaryContent(Name = "Storage", NodeType = BinaryContentTypes.Attribute)]
		public HexString Storage { get; set; }

		[BinaryContent(Name = "SpecialStorage", NodeType = BinaryContentTypes.Node)]
		public SpecialStorage SpecialStorage { get; set; }

	}
}
