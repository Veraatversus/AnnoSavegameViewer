namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class MetaInteraction {

		[BinaryContent(Name = "PropagandaChances", NodeType = BinaryContentTypes.Node)]
		public PropagandaChances PropagandaChances { get; set; }

		[BinaryContent(Name = "CurrentTradeStatus", NodeType = BinaryContentTypes.Node)]
		public CurrentTradeStatus CurrentTradeStatus { get; set; }

		[BinaryContent(Name = "NextMilitaryCalculation", NodeType = BinaryContentTypes.Attribute)]
		public HexString NextMilitaryCalculation { get; set; }

		[BinaryContent(Name = "LastMilitaryRange", NodeType = BinaryContentTypes.Node)]
		public LastMilitaryRange LastMilitaryRange { get; set; }

		[BinaryContent(Name = "LastPollutionMessage", NodeType = BinaryContentTypes.Node)]
		public LastPollutionMessage LastPollutionMessage { get; set; }

		[BinaryContent(Name = "LastAttractivenessMessage", NodeType = BinaryContentTypes.Node)]
		public LastAttractivenessMessage LastAttractivenessMessage { get; set; }

		[BinaryContent(Name = "LastWorkingConditionsEvaluation", NodeType = BinaryContentTypes.Node)]
		public LastWorkingConditionsEvaluation LastWorkingConditionsEvaluation { get; set; }

		[BinaryContent(Name = "NextWorkingConditionsEvaluation", NodeType = BinaryContentTypes.Attribute)]
		public HexString NextWorkingConditionsEvaluation { get; set; }

		[BinaryContent(Name = "LastMilitaryValue", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastMilitaryValue { get; set; }

	}
}
