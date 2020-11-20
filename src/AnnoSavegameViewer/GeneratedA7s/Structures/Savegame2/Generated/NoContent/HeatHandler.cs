namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class HeatHandler {

    [BinaryContent(Name = "Heaters", NodeType = BinaryContentTypes.Node)]
    public Heaters Heaters { get; set; }

  }
}