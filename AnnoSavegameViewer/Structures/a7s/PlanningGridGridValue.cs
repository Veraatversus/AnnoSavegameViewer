namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class PlanningGridGridValue {

		[BinaryContent(Name = "RandomFreeTile", NodeType = BinaryContentTypes.Attribute)]
		public HexString RandomFreeTile { get; set; }

		[BinaryContent(Name = "HarborOwner", NodeType = BinaryContentTypes.Attribute)]
		public HexString HarborOwner { get; set; }

		[BinaryContent(Name = "UnblockedCells", NodeType = BinaryContentTypes.Attribute)]
		public HexString UnblockedCells { get; set; }

		[BinaryContent(Name = "EdgeReachabilities", NodeType = BinaryContentTypes.Attribute)]
		public HexString EdgeReachabilities { get; set; }

		[BinaryContent(Name = "State", NodeType = BinaryContentTypes.Attribute)]
		public HexString State { get; set; }

	}
}
