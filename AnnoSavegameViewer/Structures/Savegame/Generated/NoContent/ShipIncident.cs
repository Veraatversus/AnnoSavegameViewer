using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ShipIncident {

    [BinaryContent(Name = "activeType", NodeType = BinaryContentTypes.Node)]
    public ActiveType ActiveType { get; set; }

  }
}