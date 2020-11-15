namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class MilTakeOverData {

		[BinaryContent(Name = "MoralSubstracters", NodeType = BinaryContentTypes.Node)]
		public MoralSubstracters MoralSubstracters { get; set; }

		[BinaryContent(Name = "LastAttackTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastAttackTime { get; set; }

		[BinaryContent(Name = "WarMoraleOvertakeWarning", NodeType = BinaryContentTypes.Attribute)]
		public HexString WarMoraleOvertakeWarning { get; set; }

		[BinaryContent(Name = "LastResult", NodeType = BinaryContentTypes.Node)]
		public LastResult LastResult { get; set; }

		[BinaryContent(Name = "WarMoraleOvertakeStart", NodeType = BinaryContentTypes.Attribute)]
		public HexString WarMoraleOvertakeStart { get; set; }

		[BinaryContent(Name = "WarMoraleOvertakeEnd", NodeType = BinaryContentTypes.Attribute)]
		public HexString WarMoraleOvertakeEnd { get; set; }

		[BinaryContent(Name = "WarMoraleOvertakeCalculated", NodeType = BinaryContentTypes.Attribute)]
		public HexString WarMoraleOvertakeCalculated { get; set; }

		[BinaryContent(Name = "LowMoraleNotificationSent", NodeType = BinaryContentTypes.Attribute)]
		public HexString LowMoraleNotificationSent { get; set; }

		[BinaryContent(Name = "WarActive", NodeType = BinaryContentTypes.Attribute)]
		public HexString WarActive { get; set; }

	}
}
