// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class DivingBellObjectInfoListValue {

		[BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString GUID { get; set; }

		[BinaryContent(Name = "CargoGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString CargoGUID { get; set; }

		[BinaryContent(Name = "IsTreasure", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsTreasure { get; set; }

	}
}
