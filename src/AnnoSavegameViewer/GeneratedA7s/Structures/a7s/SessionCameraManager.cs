// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class SessionCameraManager {

		[BinaryContent(Name = "UserSavedCameraStates", NodeType = BinaryContentTypes.Node)]
		public UserSavedCameraStates UserSavedCameraStates { get; set; }

		[BinaryContent(Name = "LastCameraState", NodeType = BinaryContentTypes.Node)]
		public LastCameraState LastCameraState { get; set; }

	}
}
