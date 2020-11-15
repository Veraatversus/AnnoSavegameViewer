namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class TargetParticipant {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public TargetParticipantValue Value { get; set; }

	}
}
