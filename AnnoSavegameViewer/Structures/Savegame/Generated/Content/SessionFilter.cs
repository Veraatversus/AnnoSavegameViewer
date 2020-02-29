using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SessionFilter {

    [BinaryContent(Name = "SessionGUIDs", NodeType = BinaryContentTypes.Attribute)]
    public object SessionGUIDs { get; set; }

  }
}