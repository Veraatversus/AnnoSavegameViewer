namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ShipRequirements {

    [BinaryContent(Name = "TransportationType", NodeType = BinaryContentTypes.Node)]
    public TransportationType TransportationType { get; set; }

  }
}