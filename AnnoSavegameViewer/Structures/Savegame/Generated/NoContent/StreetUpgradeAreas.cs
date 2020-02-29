using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class StreetUpgradeAreas {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<StreetUpgradeAreasList> StreetUpgradeAreasList { get; set; }

  }
}