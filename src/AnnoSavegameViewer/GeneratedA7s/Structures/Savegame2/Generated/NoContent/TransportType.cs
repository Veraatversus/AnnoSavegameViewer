namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class TransportType {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public TransportTypeValue Value { get; set; }

  }
}