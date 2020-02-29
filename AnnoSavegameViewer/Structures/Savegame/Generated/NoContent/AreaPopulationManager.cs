using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaPopulationManager {

    [BinaryContent(Name = "CitySize", NodeType = BinaryContentTypes.Node)]
    public CitySize CitySize { get; set; }

  }
}