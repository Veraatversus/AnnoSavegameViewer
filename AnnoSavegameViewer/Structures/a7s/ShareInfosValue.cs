namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ShareInfosValue {

		[BinaryContent(Name = "Bonus", NodeType = BinaryContentTypes.Attribute)]
		public Single Bonus { get; set; }

		[BinaryContent(Name = "TotalBonus", NodeType = BinaryContentTypes.Attribute)]
		public Single TotalBonus { get; set; }

		[BinaryContent(Name = "ParticipantID", NodeType = BinaryContentTypes.Node)]
		public ShareInfosValuesNoneParticipantID ParticipantID { get; set; }

	}
}
