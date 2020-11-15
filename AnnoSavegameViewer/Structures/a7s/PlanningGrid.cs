namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class PlanningGrid {

		[BinaryContent(Name = "GridOrigin", NodeType = BinaryContentTypes.Attribute)]
		public HexString GridOrigin { get; set; }

		[BinaryContent(Name = "GridMax", NodeType = BinaryContentTypes.Attribute)]
		public HexString GridMax { get; set; }

		[BinaryContent(Name = "GridDimensions", NodeType = BinaryContentTypes.Attribute)]
		public HexString GridDimensions { get; set; }

		[BinaryContent(Name = "CellSize", NodeType = BinaryContentTypes.Attribute)]
		public HexString CellSize { get; set; }

		[BinaryContent(Name = "Grid", NodeType = BinaryContentTypes.Node)]
		public PlanningGridGrid Grid { get; set; }

	}
}
