namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class TransportationType {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public TransportationTypeValue Value { get; set; }

  }
}