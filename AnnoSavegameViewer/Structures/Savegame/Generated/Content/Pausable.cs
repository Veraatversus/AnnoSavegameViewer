using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Pausable {

    [BinaryContent(Name = "PausedReasons", NodeType = BinaryContentTypes.Attribute)]
    public object PausedReasons { get; set; }

  }
}