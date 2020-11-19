// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class SessionSoundManager {

		[BinaryContent(Name = "AmbientMoodSoundHandler", NodeType = BinaryContentTypes.Node)]
		public AmbientMoodSoundHandler AmbientMoodSoundHandler { get; set; }

		[BinaryContent(Name = "EnvironmentHandler", NodeType = BinaryContentTypes.Node)]
		public EnvironmentHandler EnvironmentHandler { get; set; }

	}
}
