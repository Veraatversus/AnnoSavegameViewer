namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class SessionCameraManager {

		[BinaryContent(Name = "UserSavedCameraStates", NodeType = BinaryContentTypes.Node)]
		public UserSavedCameraStates UserSavedCameraStates { get; set; }

		[BinaryContent(Name = "LastCameraState", NodeType = BinaryContentTypes.Node)]
		public LastCameraState LastCameraState { get; set; }

	}
}
