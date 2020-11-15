namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class HorizontalEdgesValuesNoneValue {

		[BinaryContent(Name = "Positions", NodeType = BinaryContentTypes.Node)]
		public NonePositions Positions { get; set; }

		[BinaryContent(Name = "OccupyTimes", NodeType = BinaryContentTypes.Node)]
		public NoneOccupyTimes OccupyTimes { get; set; }

		[BinaryContent(Name = "SuppressRenderUpdates", NodeType = BinaryContentTypes.Attribute)]
		public HexString SuppressRenderUpdates { get; set; }

	}
}
