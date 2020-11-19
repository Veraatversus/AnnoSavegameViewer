// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class MetaDiplomacy {

		[BinaryContent(Name = "DiplomaticRelations", NodeType = BinaryContentTypes.Node)]
		public DiplomaticRelations DiplomaticRelations { get; set; }

		[BinaryContent(Name = "Allies", NodeType = BinaryContentTypes.Node)]
		public Allies Allies { get; set; }

		[BinaryContent(Name = "DiscoveredParticipants", NodeType = BinaryContentTypes.Node)]
		public DiscoveredParticipants DiscoveredParticipants { get; set; }

		[BinaryContent(Name = "MemoryTick", NodeType = BinaryContentTypes.Attribute)]
		public HexString MemoryTick { get; set; }

		[BinaryContent(Name = "GeneralTick", NodeType = BinaryContentTypes.Attribute)]
		public HexString GeneralTick { get; set; }

		[BinaryContent(Name = "NextMilitaryPaMSyTick", NodeType = BinaryContentTypes.Attribute)]
		public HexString NextMilitaryPaMSyTick { get; set; }

		[BinaryContent(Name = "LastAttacker", NodeType = BinaryContentTypes.Node)]
		public LastAttacker LastAttacker { get; set; }

		[BinaryContent(Name = "CounterProposal", NodeType = BinaryContentTypes.Node)]
		public CounterProposal CounterProposal { get; set; }

		[BinaryContent(Name = "LivingTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString LivingTime { get; set; }

		[BinaryContent(Name = "CounterIDLast", NodeType = BinaryContentTypes.Attribute)]
		public HexString CounterIDLast { get; set; }

	}
}
