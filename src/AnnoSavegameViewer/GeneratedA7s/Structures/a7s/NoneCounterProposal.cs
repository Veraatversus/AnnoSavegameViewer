// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class NoneCounterProposal {

		[BinaryContent(Name = "From", NodeType = BinaryContentTypes.Node)]
		public From From { get; set; }

		[BinaryContent(Name = "To", NodeType = BinaryContentTypes.Node)]
		public To To { get; set; }

		[BinaryContent(Name = "Actions", NodeType = BinaryContentTypes.Node)]
		public CounterProposalActions Actions { get; set; }

		[BinaryContent(Name = "m_TargetPeer", NodeType = BinaryContentTypes.Node)]
		public M_TargetPeer M_TargetPeer { get; set; }

	}
}
