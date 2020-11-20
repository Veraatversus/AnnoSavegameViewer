// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class NoneTradedGoodsValue {

		[BinaryContent(Name = "GoodGuid", NodeType = BinaryContentTypes.Attribute)]
		public HexString GoodGuid { get; set; }

		[BinaryContent(Name = "GoodAmount", NodeType = BinaryContentTypes.Attribute)]
		public HexString GoodAmount { get; set; }

		[BinaryContent(Name = "TotalPrice", NodeType = BinaryContentTypes.Attribute)]
		public HexString TotalPrice { get; set; }

	}
}
