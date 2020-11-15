namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class SessionHandler {

		[BinaryContent(Name = "EnteredSessions", NodeType = BinaryContentTypes.Node)]
		public EnteredSessions EnteredSessions { get; set; }

		[BinaryContent(Name = "EnterSessionMission", NodeType = BinaryContentTypes.Node)]
		public EnterSessionMission EnterSessionMission { get; set; }

	}
}
