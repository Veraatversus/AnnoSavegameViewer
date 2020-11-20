// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using System;

	public partial class BinaryData {

		[BinaryContent(Name = "SessionFileVersion", NodeType = BinaryContentTypes.Attribute)]
		public Int32 SessionFileVersion { get; set; }

		[BinaryContent(Name = "GameSessionManager", NodeType = BinaryContentTypes.Node)]
		public GameSessionManager GameSessionManager { get; set; }

	}
}
