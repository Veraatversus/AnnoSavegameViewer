using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaPopulationManager {

    [BinaryContent(Name = "CitySize", NodeType = BinaryContentTypes.Node)]
    public CitySize CitySize { get; set; }

    [BinaryContent(Name = "TriggeredBanners", NodeType = BinaryContentTypes.Node)]
    public TriggeredBanners TriggeredBanners { get; set; }

  }
}