// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class Pair {

		[BinaryContent(Name = "ParticipantID", NodeType = BinaryContentTypes.Node)]
		public PairParticipantID ParticipantID { get; set; }

		[BinaryContent(Name = "MetaEconomy", NodeType = BinaryContentTypes.Node)]
		public MetaEconomy MetaEconomy { get; set; }

	}
}
