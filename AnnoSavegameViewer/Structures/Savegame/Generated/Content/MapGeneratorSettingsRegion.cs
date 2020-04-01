using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MapGeneratorSettingsRegion {

    [BinaryContent(Name = "region", NodeType = BinaryContentTypes.Attribute)]
    public object Region { get; set; }

  }
}