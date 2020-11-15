namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class SessionData {

		[BinaryContent(Name = "BinaryData", NodeType = BinaryContentTypes.Attribute, ConversationType = ConversationTypes.FileDB)]
		public BinaryData BinaryData { get; set; }

	}
}
