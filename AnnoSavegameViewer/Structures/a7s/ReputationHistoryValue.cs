namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ReputationHistoryValue {

		[BinaryContent(Name = "TextGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString TextGUID { get; set; }

		[BinaryContent(Name = "ReputationChange", NodeType = BinaryContentTypes.Attribute)]
		public HexString ReputationChange { get; set; }

	}
}
