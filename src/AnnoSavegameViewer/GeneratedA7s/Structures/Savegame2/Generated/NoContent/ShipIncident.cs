namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ShipIncident {

    [BinaryContent(Name = "activeType", NodeType = BinaryContentTypes.Node)]
    public ActiveType ActiveType { get; set; }

  }
}