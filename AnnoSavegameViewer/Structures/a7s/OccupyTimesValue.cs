namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class OccupyTimesValue {

		[BinaryContent(Name = "TrainOwner", NodeType = BinaryContentTypes.Node)]
		public TrainOwner TrainOwner { get; set; }

		[BinaryContent(Name = "TrainID", NodeType = BinaryContentTypes.Attribute)]
		public HexString TrainID { get; set; }

		[BinaryContent(Name = "EnterTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString EnterTime { get; set; }

		[BinaryContent(Name = "LeaveTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString LeaveTime { get; set; }

	}
}
