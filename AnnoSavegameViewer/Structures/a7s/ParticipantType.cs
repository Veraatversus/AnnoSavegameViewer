namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ParticipantType {

		[BinaryContent(Name = "Values", NodeType = BinaryContentTypes.Node)]
		public ParticipantTypeValues Values { get; set; }

	}
}
