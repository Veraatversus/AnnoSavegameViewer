// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class InteractionsValue {

		[BinaryContent(Name = "AutoClose", NodeType = BinaryContentTypes.Attribute)]
		public HexString AutoClose { get; set; }

		[BinaryContent(Name = "IconGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString IconGUID { get; set; }

		[BinaryContent(Name = "Callback", NodeType = BinaryContentTypes.Attribute)]
		public HexString Callback { get; set; }

	}
}
