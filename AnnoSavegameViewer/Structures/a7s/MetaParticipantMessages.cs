namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class MetaParticipantMessages {

		[BinaryContent(Name = "TriggerCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString TriggerCount { get; set; }

		[BinaryContent(Name = "MessageStates", NodeType = BinaryContentTypes.Node)]
		public MessageStates MessageStates { get; set; }

		[BinaryContent(Name = "UniqueMessagesSent", NodeType = BinaryContentTypes.Node)]
		public UniqueMessagesSent UniqueMessagesSent { get; set; }

		[BinaryContent(Name = "Deactivated", NodeType = BinaryContentTypes.Attribute)]
		public HexString Deactivated { get; set; }

	}
}
