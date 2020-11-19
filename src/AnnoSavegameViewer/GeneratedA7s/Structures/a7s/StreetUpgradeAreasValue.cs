// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class StreetUpgradeAreasValue {

		[BinaryContent(Name = "Center", NodeType = BinaryContentTypes.Attribute)]
		public HexString Center { get; set; }

		[BinaryContent(Name = "CurrentSideLength", NodeType = BinaryContentTypes.Attribute)]
		public HexString CurrentSideLength { get; set; }

		[BinaryContent(Name = "SideLengthMax", NodeType = BinaryContentTypes.Attribute)]
		public HexString SideLengthMax { get; set; }

	}
}
