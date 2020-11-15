namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class MessageManager {

		[BinaryContent(Name = "NGT", NodeType = BinaryContentTypes.Node)]
		public MessageManagerNGT NGT { get; set; }

		[BinaryContent(Name = "ActionQueue", NodeType = BinaryContentTypes.Node)]
		public MessageManagerActionQueue ActionQueue { get; set; }

	}
}
