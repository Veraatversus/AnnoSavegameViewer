namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Seamines {

		[BinaryContent(Name = "MineProhibitZones", NodeType = BinaryContentTypes.Node)]
		public MineProhibitZones MineProhibitZones { get; set; }

		[BinaryContent(Name = "TargetPos", NodeType = BinaryContentTypes.Node)]
		public TargetPos TargetPos { get; set; }

		[BinaryContent(Name = "CurrentMines", NodeType = BinaryContentTypes.Node)]
		public CurrentMines CurrentMines { get; set; }

		[BinaryContent(Name = "VisitedHarbors", NodeType = BinaryContentTypes.Node)]
		public VisitedHarbors VisitedHarbors { get; set; }

		[BinaryContent(Name = "NextMineSpawn", NodeType = BinaryContentTypes.Attribute)]
		public HexString NextMineSpawn { get; set; }

		[BinaryContent(Name = "MineAreas", NodeType = BinaryContentTypes.Node)]
		public MineAreas MineAreas { get; set; }

	}
}
