// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class FineGrid {

		[BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
		public HexString AreaID { get; set; }

		[BinaryContent(Name = "Origin", NodeType = BinaryContentTypes.Attribute)]
		public HexString Origin { get; set; }

		[BinaryContent(Name = "Max", NodeType = BinaryContentTypes.Attribute)]
		public HexString Max { get; set; }

		[BinaryContent(Name = "Dimensions", NodeType = BinaryContentTypes.Attribute)]
		public HexString Dimensions { get; set; }

		[BinaryContent(Name = "LandBuildableRect", NodeType = BinaryContentTypes.Attribute)]
		public HexString LandBuildableRect { get; set; }

		[BinaryContent(Name = "FineGridData", NodeType = BinaryContentTypes.Attribute)]
		public HexString FineGridData { get; set; }

	}
}
