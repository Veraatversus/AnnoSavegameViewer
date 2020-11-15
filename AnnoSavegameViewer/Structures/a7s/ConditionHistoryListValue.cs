namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ConditionHistoryListValue {

		[BinaryContent(Name = "ConditionCombinedText", NodeType = BinaryContentTypes.Node)]
		public ConditionCombinedText ConditionCombinedText { get; set; }

		[BinaryContent(Name = "ConditionResult", NodeType = BinaryContentTypes.Node)]
		public NoneConditionResult ConditionResult { get; set; }

		[BinaryContent(Name = "Separator", NodeType = BinaryContentTypes.Node)]
		public Separator Separator { get; set; }

	}
}
