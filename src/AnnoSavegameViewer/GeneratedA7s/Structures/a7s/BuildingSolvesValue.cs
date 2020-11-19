// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class BuildingSolvesValue {

		[BinaryContent(Name = "Guid", NodeType = BinaryContentTypes.Attribute)]
		public HexString Guid { get; set; }

		[BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
		public HexString AreaID { get; set; }

		[BinaryContent(Name = "Timestamp", NodeType = BinaryContentTypes.Attribute)]
		public HexString Timestamp { get; set; }

		[BinaryContent(Name = "SessionGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString SessionGUID { get; set; }

	}
}
