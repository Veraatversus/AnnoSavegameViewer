namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class MetaTrader {

		[BinaryContent(Name = "ImperialKontorSession", NodeType = BinaryContentTypes.Attribute)]
		public HexString ImperialKontorSession { get; set; }

		[BinaryContent(Name = "ImperialKontorID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ImperialKontorID { get; set; }

	}
}
