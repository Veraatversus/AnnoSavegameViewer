namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class AreaLayout {

		[BinaryContent(Name = "FineGrid", NodeType = BinaryContentTypes.Node)]
		public FineGrid FineGrid { get; set; }

		[BinaryContent(Name = "StaticGrid", NodeType = BinaryContentTypes.Node)]
		public StaticGrid StaticGrid { get; set; }

		[BinaryContent(Name = "PlanningGrid", NodeType = BinaryContentTypes.Node)]
		public PlanningGrid PlanningGrid { get; set; }

		[BinaryContent(Name = "MiscGrid", NodeType = BinaryContentTypes.Node)]
		public MiscGrid MiscGrid { get; set; }

		[BinaryContent(Name = "Districts", NodeType = BinaryContentTypes.Node)]
		public Districts Districts { get; set; }

		[BinaryContent(Name = "LayoutPlanner", NodeType = BinaryContentTypes.Node)]
		public LayoutPlanner LayoutPlanner { get; set; }

		[BinaryContent(Name = "RailwayHandler", NodeType = BinaryContentTypes.Node)]
		public RailwayHandler RailwayHandler { get; set; }

		[BinaryContent(Name = "ElectricityHandler", NodeType = BinaryContentTypes.Node)]
		public ElectricityHandler ElectricityHandler { get; set; }

		[BinaryContent(Name = "HeatHandler", NodeType = BinaryContentTypes.Node)]
		public HeatHandler HeatHandler { get; set; }

		[BinaryContent(Name = "IrrigationHandler", NodeType = BinaryContentTypes.Node)]
		public IrrigationHandler IrrigationHandler { get; set; }

		[BinaryContent(Name = "KontorBlocking", NodeType = BinaryContentTypes.Attribute)]
		public HexString KontorBlocking { get; set; }

		[BinaryContent(Name = "KontorRotation", NodeType = BinaryContentTypes.Node)]
		public KontorRotation KontorRotation { get; set; }

		[BinaryContent(Name = "StreetPlanner", NodeType = BinaryContentTypes.Node)]
		public StreetPlanner StreetPlanner { get; set; }

	}
}
