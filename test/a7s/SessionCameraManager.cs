using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class SessionCameraManager {

[BinaryContent(Name = "UserSavedCameraStates", NodeType = BinaryContentTypes.Node)]
public UserSavedCameraStates UserSavedCameraStates { get; set; }

[BinaryContent(Name = "LastCameraState", NodeType = BinaryContentTypes.Node)]
public LastCameraState LastCameraState { get; set; }

}
}
