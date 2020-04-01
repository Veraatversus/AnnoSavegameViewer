using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MinimapManager {

    [BinaryContent(Name = "CityDataSize", NodeType = BinaryContentTypes.Attribute)]
    public object CityDataSize { get; set; }

    [BinaryContent(Name = "CityData", NodeType = BinaryContentTypes.Attribute)]
    public object CityData { get; set; }

  }
}