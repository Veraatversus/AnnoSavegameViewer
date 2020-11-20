namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class CurrentPosition {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public CurrentPositionValue Value { get; set; }

  }
}