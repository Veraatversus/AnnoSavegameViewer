// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class GameSessionsValue {

		[BinaryContent(Name = "SessionDesc", NodeType = BinaryContentTypes.Node)]
		public SessionDesc SessionDesc { get; set; }

		[BinaryContent(Name = "SessionData", NodeType = BinaryContentTypes.Node)]
		public SessionData SessionData { get; set; }

	}
}
