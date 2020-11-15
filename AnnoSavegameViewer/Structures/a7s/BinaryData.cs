namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class BinaryData {

		[BinaryContent(Name = "SessionFileVersion", NodeType = BinaryContentTypes.Attribute)]
		public Int32 SessionFileVersion { get; set; }

		[BinaryContent(Name = "GameSessionManager", NodeType = BinaryContentTypes.Node)]
		public GameSessionManager GameSessionManager { get; set; }

	}
}
