using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class UserSavedCameraStatesList {

    [BinaryContent(Name = "PresetId", NodeType = BinaryContentTypes.Attribute)]
    public object PresetId { get; set; }

    [BinaryContent(Name = "View", NodeType = BinaryContentTypes.Node)]
    public View View { get; set; }

    [BinaryContent(Name = "Projection", NodeType = BinaryContentTypes.Node)]
    public Projection Projection { get; set; }

  }
}