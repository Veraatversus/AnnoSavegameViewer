// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class CrisesValue {

		[BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Node)]
		public ValuesNoneType Type { get; set; }

		[BinaryContent(Name = "Area", NodeType = BinaryContentTypes.Attribute)]
		public HexString Area { get; set; }

		[BinaryContent(Name = "Creation", NodeType = BinaryContentTypes.Attribute)]
		public HexString Creation { get; set; }

		[BinaryContent(Name = "Product", NodeType = BinaryContentTypes.Attribute)]
		public HexString Product { get; set; }

	}
}
