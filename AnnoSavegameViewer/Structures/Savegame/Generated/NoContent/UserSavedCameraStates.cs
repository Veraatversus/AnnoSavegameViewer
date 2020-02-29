using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class UserSavedCameraStates {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<UserSavedCameraStatesList> UserSavedCameraStatesList { get; set; }

  }
}