// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class GoodInfosValue {

		[BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ID { get; set; }

		[BinaryContent(Name = "StationID", NodeType = BinaryContentTypes.Attribute)]
		public HexString StationID { get; set; }

		[BinaryContent(Name = "ProductGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ProductGUID { get; set; }

		[BinaryContent(Name = "Amount", NodeType = BinaryContentTypes.Attribute)]
		public HexString Amount { get; set; }

		[BinaryContent(Name = "Index", NodeType = BinaryContentTypes.Attribute)]
		public HexString Index { get; set; }

		[BinaryContent(Name = "IsLoading", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsLoading { get; set; }

	}
}
