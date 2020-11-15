namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class MetaMessageManager {

		[BinaryContent(Name = "NGT", NodeType = BinaryContentTypes.Node)]
		public NGT NGT { get; set; }

		[BinaryContent(Name = "ActionQueue", NodeType = BinaryContentTypes.Node)]
		public ActionQueue ActionQueue { get; set; }

	}
}
