using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SessionData {

    [BinaryContent(Name = "BinaryData", NodeType = BinaryContentTypes.Node)]
    public BinaryData BinaryData { get; set; }

  }
}