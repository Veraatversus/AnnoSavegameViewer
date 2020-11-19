// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class VerticalEdgesValuesNoneValue {

		[BinaryContent(Name = "Positions", NodeType = BinaryContentTypes.Node)]
		public Positions Positions { get; set; }

		[BinaryContent(Name = "OccupyTimes", NodeType = BinaryContentTypes.Node)]
		public OccupyTimes OccupyTimes { get; set; }

		[BinaryContent(Name = "SuppressRenderUpdates", NodeType = BinaryContentTypes.Attribute)]
		public HexString SuppressRenderUpdates { get; set; }

	}
}
