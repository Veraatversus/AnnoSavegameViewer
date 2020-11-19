// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class Sellable {

		[BinaryContent(Name = "allowedBuyers", NodeType = BinaryContentTypes.Attribute)]
		public HexString AllowedBuyers { get; set; }

		[BinaryContent(Name = "onSale", NodeType = BinaryContentTypes.Attribute)]
		public HexString OnSale { get; set; }

	}
}
