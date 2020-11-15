namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class M_IslandPrioritiesValue {

		[BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
		public HexString AreaID { get; set; }

		[BinaryContent(Name = "MoneyCost", NodeType = BinaryContentTypes.Attribute)]
		public HexString MoneyCost { get; set; }

		[BinaryContent(Name = "PrioType", NodeType = BinaryContentTypes.Node)]
		public PrioType PrioType { get; set; }

		[BinaryContent(Name = "ShareIndex", NodeType = BinaryContentTypes.Attribute)]
		public HexString ShareIndex { get; set; }

		[BinaryContent(Name = "Prio", NodeType = BinaryContentTypes.Attribute)]
		public HexString Prio { get; set; }

		[BinaryContent(Name = "MissingMoney", NodeType = BinaryContentTypes.Attribute)]
		public HexString MissingMoney { get; set; }

		[BinaryContent(Name = "ShareCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString ShareCount { get; set; }

	}
}
