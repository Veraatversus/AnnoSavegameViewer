namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class CivLevel {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public CivLevelValue Value { get; set; }

  }
}