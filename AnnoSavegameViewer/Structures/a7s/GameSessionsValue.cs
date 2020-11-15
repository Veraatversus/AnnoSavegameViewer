namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class GameSessionsValue {

		[BinaryContent(Name = "SessionDesc", NodeType = BinaryContentTypes.Node)]
		public SessionDesc SessionDesc { get; set; }

		[BinaryContent(Name = "SessionData", NodeType = BinaryContentTypes.Node)]
		public SessionData SessionData { get; set; }

	}
}
