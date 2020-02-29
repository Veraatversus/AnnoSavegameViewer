using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class UserSavedCameraStatesList {

    [BinaryContent(Name = "View", NodeType = BinaryContentTypes.Node)]
    public View View { get; set; }

    [BinaryContent(Name = "Projection", NodeType = BinaryContentTypes.Node)]
    public Projection Projection { get; set; }

  }
}