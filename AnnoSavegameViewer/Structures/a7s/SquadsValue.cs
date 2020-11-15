namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class SquadsValue {

		[BinaryContent(Name = "mapKey", NodeType = BinaryContentTypes.Attribute)]
		public HexString MapKey { get; set; }

		[BinaryContent(Name = "mapContext", NodeType = BinaryContentTypes.Attribute)]
		public HexString MapContext { get; set; }

		[BinaryContent(Name = "LastAITick", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastAITick { get; set; }

		[BinaryContent(Name = "m_SquadID", NodeType = BinaryContentTypes.Attribute)]
		public HexString M_SquadID { get; set; }

		[BinaryContent(Name = "m_PathPlannerLayer", NodeType = BinaryContentTypes.Node)]
		public M_PathPlannerLayer M_PathPlannerLayer { get; set; }

		[BinaryContent(Name = "SquadUnits", NodeType = BinaryContentTypes.Node)]
		public SquadUnits SquadUnits { get; set; }

		[BinaryContent(Name = "taskQueueSize", NodeType = BinaryContentTypes.Attribute)]
		public HexString TaskQueueSize { get; set; }

		[BinaryContent(Name = "taskType", NodeType = BinaryContentTypes.Attribute)]
		public HexString TaskType { get; set; }

		[BinaryContent(Name = "RoutePoints", NodeType = BinaryContentTypes.Attribute)]
		public HexString RoutePoints { get; set; }

		[BinaryContent(Name = "RoutePausedSince", NodeType = BinaryContentTypes.Attribute)]
		public HexString RoutePausedSince { get; set; }

		[BinaryContent(Name = "ReverseDirection", NodeType = BinaryContentTypes.Attribute)]
		public HexString ReverseDirection { get; set; }

		[BinaryContent(Name = "EscortID", NodeType = BinaryContentTypes.Attribute)]
		public HexString EscortID { get; set; }

		[BinaryContent(Name = "CurrentPointIndex", NodeType = BinaryContentTypes.Attribute)]
		public HexString CurrentPointIndex { get; set; }

		[BinaryContent(Name = "TargetPosition", NodeType = BinaryContentTypes.Attribute)]
		public HexString TargetPosition { get; set; }

		[BinaryContent(Name = "ParticipantID", NodeType = BinaryContentTypes.Node)]
		public SquadsValuesNoneParticipantID ParticipantID { get; set; }

		[BinaryContent(Name = "FleePos", NodeType = BinaryContentTypes.Attribute)]
		public HexString FleePos { get; set; }

	}
}
