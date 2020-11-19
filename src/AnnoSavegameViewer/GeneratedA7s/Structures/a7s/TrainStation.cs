// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class TrainStation {

		[BinaryContent(Name = "WaypointList", NodeType = BinaryContentTypes.Node)]
		public WaypointList WaypointList { get; set; }

		[BinaryContent(Name = "BlockedTrainInfos", NodeType = BinaryContentTypes.Node)]
		public BlockedTrainInfos BlockedTrainInfos { get; set; }

		[BinaryContent(Name = "LastTrainSend", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastTrainSend { get; set; }

		[BinaryContent(Name = "m_EarliestTrain", NodeType = BinaryContentTypes.Attribute)]
		public HexString M_EarliestTrain { get; set; }

		[BinaryContent(Name = "m_LoadCapacity", NodeType = BinaryContentTypes.Attribute)]
		public HexString M_LoadCapacity { get; set; }

	}
}
