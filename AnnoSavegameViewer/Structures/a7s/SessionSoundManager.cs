namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class SessionSoundManager {

		[BinaryContent(Name = "AmbientMoodSoundHandler", NodeType = BinaryContentTypes.Node)]
		public AmbientMoodSoundHandler AmbientMoodSoundHandler { get; set; }

		[BinaryContent(Name = "EnvironmentHandler", NodeType = BinaryContentTypes.Node)]
		public EnvironmentHandler EnvironmentHandler { get; set; }

	}
}
