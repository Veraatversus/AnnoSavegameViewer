namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class NewspaperManager {

		[BinaryContent(Name = "IDManager", NodeType = BinaryContentTypes.Node)]
		public IDManager IDManager { get; set; }

		[BinaryContent(Name = "ParticipantData", NodeType = BinaryContentTypes.Node)]
		public ParticipantData ParticipantData { get; set; }

	}
}
