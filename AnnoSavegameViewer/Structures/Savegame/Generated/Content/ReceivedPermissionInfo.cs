using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ReceivedPermissionInfo {

    [BinaryContent(Name = "LastChange", NodeType = BinaryContentTypes.Attribute)]
    public object LastChange { get; set; }

  }
}