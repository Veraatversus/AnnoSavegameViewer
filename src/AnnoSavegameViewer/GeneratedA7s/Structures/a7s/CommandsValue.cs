// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class CommandsValue {

		[BinaryContent(Name = "SessionID", NodeType = BinaryContentTypes.Attribute)]
		public HexString SessionID { get; set; }

		[BinaryContent(Name = "NextTickTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString NextTickTime { get; set; }

		[BinaryContent(Name = "Parent", NodeType = BinaryContentTypes.Node)]
		public ValuesNoneParent Parent { get; set; }

		[BinaryContent(Name = "CommandGroupInformation", NodeType = BinaryContentTypes.Node)]
		public CommandGroupInformation CommandGroupInformation { get; set; }

		[BinaryContent(Name = "StopRadius", NodeType = BinaryContentTypes.Attribute)]
		public HexString StopRadius { get; set; }

		[BinaryContent(Name = "TargetDir", NodeType = BinaryContentTypes.Attribute)]
		public HexString TargetDir { get; set; }

		[BinaryContent(Name = "AddLaneOffset", NodeType = BinaryContentTypes.Attribute)]
		public HexString AddLaneOffset { get; set; }

		[BinaryContent(Name = "TargetObjectID", NodeType = BinaryContentTypes.Attribute)]
		public HexString TargetObjectID { get; set; }

		[BinaryContent(Name = "MainState", NodeType = BinaryContentTypes.Attribute)]
		public HexString MainState { get; set; }

		[BinaryContent(Name = "WayPositions", NodeType = BinaryContentTypes.Attribute)]
		public HexString WayPositions { get; set; }

		[BinaryContent(Name = "DriftingInstruction", NodeType = BinaryContentTypes.Node)]
		public DriftingInstruction DriftingInstruction { get; set; }

		[BinaryContent(Name = "CurrentTargetIndex", NodeType = BinaryContentTypes.Attribute)]
		public HexString CurrentTargetIndex { get; set; }

		[BinaryContent(Name = "DangerLayerID", NodeType = BinaryContentTypes.Attribute)]
		public HexString DangerLayerID { get; set; }

		[BinaryContent(Name = "CommandType", NodeType = BinaryContentTypes.Attribute)]
		public HexString CommandType { get; set; }

		[BinaryContent(Name = "TargetSession", NodeType = BinaryContentTypes.Attribute)]
		public HexString TargetSession { get; set; }

		[BinaryContent(Name = "TargetPosition", NodeType = BinaryContentTypes.Attribute)]
		public HexString TargetPosition { get; set; }

		[BinaryContent(Name = "TargetDirection", NodeType = BinaryContentTypes.Attribute)]
		public HexString TargetDirection { get; set; }

		[BinaryContent(Name = "StillWaitingForGroup", NodeType = BinaryContentTypes.Attribute)]
		public HexString StillWaitingForGroup { get; set; }

		[BinaryContent(Name = "NoLogicOutOfPlayable", NodeType = BinaryContentTypes.Attribute)]
		public HexString NoLogicOutOfPlayable { get; set; }

		[BinaryContent(Name = "InvokedByHuman", NodeType = BinaryContentTypes.Attribute)]
		public HexString InvokedByHuman { get; set; }

		[BinaryContent(Name = "DestructContext", NodeType = BinaryContentTypes.Node)]
		public NoneDestructContext DestructContext { get; set; }

	}
}
