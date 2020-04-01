using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ActiveRegionsList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ActiveRegionsListValue Value { get; set; }

  }
}