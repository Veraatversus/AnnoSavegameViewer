namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class SettleHandler {

		[BinaryContent(Name = "LastSettleTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastSettleTime { get; set; }

		[BinaryContent(Name = "NextSettleMissionID", NodeType = BinaryContentTypes.Attribute)]
		public HexString NextSettleMissionID { get; set; }

		[BinaryContent(Name = "SettleMission", NodeType = BinaryContentTypes.Node)]
		public SettleMission SettleMission { get; set; }

	}
}
