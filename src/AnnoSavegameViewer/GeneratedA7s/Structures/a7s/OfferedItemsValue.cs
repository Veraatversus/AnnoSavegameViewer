// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class OfferedItemsValue {

		[BinaryContent(Name = "Amount", NodeType = BinaryContentTypes.Attribute)]
		public Int32 Amount { get; set; }

		[BinaryContent(Name = "AssetGUID", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt AssetGUID { get; set; }

	}
}
