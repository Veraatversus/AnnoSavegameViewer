namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class PrioType {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public PrioTypeValue Value { get; set; }

  }
}