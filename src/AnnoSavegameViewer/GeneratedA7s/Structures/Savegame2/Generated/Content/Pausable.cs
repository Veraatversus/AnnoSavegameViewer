namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class Pausable {

    [BinaryContent(Name = "PausedReasons", NodeType = BinaryContentTypes.Attribute)]
    public object PausedReasons { get; set; }

  }
}