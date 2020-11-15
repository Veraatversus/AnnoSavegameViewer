namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class MinistryStatesValue {

		[BinaryContent(Name = "UnlockedState", NodeType = BinaryContentTypes.Attribute)]
		public HexString UnlockedState { get; set; }

		[BinaryContent(Name = "HighlightState", NodeType = BinaryContentTypes.Attribute)]
		public HexString HighlightState { get; set; }

	}
}
