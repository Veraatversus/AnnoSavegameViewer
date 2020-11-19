// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class SettleLocation {

		[BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
		public HexString AreaID { get; set; }

		[BinaryContent(Name = "Stopover", NodeType = BinaryContentTypes.Attribute)]
		public HexString Stopover { get; set; }

		[BinaryContent(Name = "ApproachType", NodeType = BinaryContentTypes.Node)]
		public ApproachType ApproachType { get; set; }

		[BinaryContent(Name = "Coastline", NodeType = BinaryContentTypes.Node)]
		public Coastline Coastline { get; set; }

		[BinaryContent(Name = "KontorPos", NodeType = BinaryContentTypes.Attribute)]
		public HexString KontorPos { get; set; }

		[BinaryContent(Name = "RecommendedPos", NodeType = BinaryContentTypes.Node)]
		public RecommendedPos RecommendedPos { get; set; }

	}
}
