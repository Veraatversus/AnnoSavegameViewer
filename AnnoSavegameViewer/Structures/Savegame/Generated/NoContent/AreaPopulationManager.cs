namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class AreaPopulationManager {

    [BinaryContent(Name = "CitySize", NodeType = BinaryContentTypes.Node)]
    public CitySize CitySize { get; set; }

    [BinaryContent(Name = "TriggeredBanners", NodeType = BinaryContentTypes.Node)]
    public TriggeredBanners TriggeredBanners { get; set; }

  }
}