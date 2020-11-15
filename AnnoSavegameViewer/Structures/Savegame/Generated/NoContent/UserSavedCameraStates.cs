namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class UserSavedCameraStates {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<UserSavedCameraStatesList> UserSavedCameraStatesList { get; set; }

  }
}