// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class ProductDistributionMapValue {

		[BinaryContent(Name = "ProductLeft", NodeType = BinaryContentTypes.Attribute)]
		public HexString ProductLeft { get; set; }

		[BinaryContent(Name = "ProductConsumption", NodeType = BinaryContentTypes.Attribute)]
		public HexString ProductConsumption { get; set; }

		[BinaryContent(Name = "DistributionPausedInfo", NodeType = BinaryContentTypes.Node)]
		public DistributionPausedInfo DistributionPausedInfo { get; set; }

	}
}
