using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ShipRequirements {

    [BinaryContent(Name = "TransportationType", NodeType = BinaryContentTypes.Node)]
    public TransportationType TransportationType { get; set; }

  }
}