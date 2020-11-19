// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class SessionHandler {

		[BinaryContent(Name = "EnteredSessions", NodeType = BinaryContentTypes.Node)]
		public EnteredSessions EnteredSessions { get; set; }

		[BinaryContent(Name = "EnterSessionMission", NodeType = BinaryContentTypes.Node)]
		public EnterSessionMission EnterSessionMission { get; set; }

	}
}
