// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class DiplomaticRelationsValue {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public DiplomaticRelationsValuesNoneValue Value { get; set; }

		[BinaryContent(Name = "Reputation", NodeType = BinaryContentTypes.Attribute)]
		public HexString Reputation { get; set; }

		[BinaryContent(Name = "ReputationMemory", NodeType = BinaryContentTypes.Attribute)]
		public HexString ReputationMemory { get; set; }

		[BinaryContent(Name = "MemoryTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString MemoryTime { get; set; }

		[BinaryContent(Name = "Source", NodeType = BinaryContentTypes.Node)]
		public NoneSource Source { get; set; }

		[BinaryContent(Name = "Destination", NodeType = BinaryContentTypes.Node)]
		public Destination Destination { get; set; }

		[BinaryContent(Name = "DiplomacyStates", NodeType = BinaryContentTypes.Node)]
		public DiplomacyStates DiplomacyStates { get; set; }

		[BinaryContent(Name = "Debuffs", NodeType = BinaryContentTypes.Node)]
		public Debuffs Debuffs { get; set; }

		[BinaryContent(Name = "ReputationHistory", NodeType = BinaryContentTypes.Node)]
		public ReputationHistory ReputationHistory { get; set; }

		[BinaryContent(Name = "m_DiscoverTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString M_DiscoverTime { get; set; }

		[BinaryContent(Name = "RepeatableActionZero", NodeType = BinaryContentTypes.Attribute)]
		public HexString RepeatableActionZero { get; set; }

		[BinaryContent(Name = "m_TriggerTimes", NodeType = BinaryContentTypes.Node)]
		public M_TriggerTimes M_TriggerTimes { get; set; }

	}
}