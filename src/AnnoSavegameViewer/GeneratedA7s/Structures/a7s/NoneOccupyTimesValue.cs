// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using System;

	public partial class NoneOccupyTimesValue {

		[BinaryContent(Name = "TrainOwner", NodeType = BinaryContentTypes.Node)]
		public NoneTrainOwner TrainOwner { get; set; }

		[BinaryContent(Name = "TrainID", NodeType = BinaryContentTypes.Attribute)]
		public Int64 TrainID { get; set; }

		[BinaryContent(Name = "EnterTime", NodeType = BinaryContentTypes.Attribute)]
		public TimeSpan EnterTime { get; set; }

		[BinaryContent(Name = "LeaveTime", NodeType = BinaryContentTypes.Attribute)]
		public TimeSpan LeaveTime { get; set; }

	}
}
