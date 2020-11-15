namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class WorkforceTransferManager {

		[BinaryContent(Name = "ParticipantData", NodeType = BinaryContentTypes.Node)]
		public WorkforceTransferManagerParticipantData ParticipantData { get; set; }

	}
}
