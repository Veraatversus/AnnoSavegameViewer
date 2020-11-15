namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Walking {

		[BinaryContent(Name = "LeaningChanged", NodeType = BinaryContentTypes.Attribute)]
		public Boolean LeaningChanged { get; set; }

		[BinaryContent(Name = "Leaning", NodeType = BinaryContentTypes.Attribute)]
		public Single Leaning { get; set; }

		[BinaryContent(Name = "ExternalSpeedFactor", NodeType = BinaryContentTypes.Attribute)]
		public Single ExternalSpeedFactor { get; set; }

		[BinaryContent(Name = "Reservation", NodeType = BinaryContentTypes.Node)]
		public Reservation Reservation { get; set; }

		[BinaryContent(Name = "Way", NodeType = BinaryContentTypes.Node)]
		public Way Way { get; set; }

		[BinaryContent(Name = "WayTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString WayTime { get; set; }

		[BinaryContent(Name = "LastPos", NodeType = BinaryContentTypes.Attribute)]
		public Point3D<Single> LastPos { get; set; }

		[BinaryContent(Name = "LastWaystepPos", NodeType = BinaryContentTypes.Attribute)]
		public Point3D<Single> LastWaystepPos { get; set; }

		[BinaryContent(Name = "LastTickPos", NodeType = BinaryContentTypes.Attribute)]
		public Point3D<Single> LastTickPos { get; set; }

		[BinaryContent(Name = "LastDirView", NodeType = BinaryContentTypes.Attribute)]
		public Single LastDirView { get; set; }

		[BinaryContent(Name = "LastDirLogic", NodeType = BinaryContentTypes.Attribute)]
		public Single LastDirLogic { get; set; }

		[BinaryContent(Name = "LastDeltaDirDelta", NodeType = BinaryContentTypes.Attribute)]
		public Single LastDeltaDirDelta { get; set; }

		[BinaryContent(Name = "GroupMemberInformation", NodeType = BinaryContentTypes.Node)]
		public GroupMemberInformation GroupMemberInformation { get; set; }

		[BinaryContent(Name = "TargetPosition", NodeType = BinaryContentTypes.Node)]
		public TargetPosition TargetPosition { get; set; }

		[BinaryContent(Name = "CombatRange", NodeType = BinaryContentTypes.Node)]
		public CombatRange CombatRange { get; set; }

		[BinaryContent(Name = "WasMovingLastTick", NodeType = BinaryContentTypes.Attribute)]
		public HexString WasMovingLastTick { get; set; }

		[BinaryContent(Name = "PreventDriftBack", NodeType = BinaryContentTypes.Attribute)]
		public HexString PreventDriftBack { get; set; }

		[BinaryContent(Name = "PathBackground", NodeType = BinaryContentTypes.Node)]
		public PathBackground PathBackground { get; set; }

		[BinaryContent(Name = "OldUnitID", NodeType = BinaryContentTypes.Attribute)]
		public HexString OldUnitID { get; set; }

		[BinaryContent(Name = "Moving", NodeType = BinaryContentTypes.Attribute)]
		public Boolean Moving { get; set; }

		[BinaryContent(Name = "WasMoving", NodeType = BinaryContentTypes.Attribute)]
		public Boolean WasMoving { get; set; }

		[BinaryContent(Name = "IdleTickCount", NodeType = BinaryContentTypes.Attribute)]
		public Byte IdleTickCount { get; set; }

		[BinaryContent(Name = "DriftingOffset", NodeType = BinaryContentTypes.Attribute)]
		public Point2D<Single> DriftingOffset { get; set; }

		[BinaryContent(Name = "DriftingForce", NodeType = BinaryContentTypes.Attribute)]
		public Point2D<Single> DriftingForce { get; set; }

		[BinaryContent(Name = "ForceReachWaytepRot", NodeType = BinaryContentTypes.Attribute)]
		public HexString ForceReachWaytepRot { get; set; }

		[BinaryContent(Name = "ArrivalTimer", NodeType = BinaryContentTypes.Attribute)]
		public HexString ArrivalTimer { get; set; }

		[BinaryContent(Name = "CatchUpFactor", NodeType = BinaryContentTypes.Attribute)]
		public Single CatchUpFactor { get; set; }

	}
}
