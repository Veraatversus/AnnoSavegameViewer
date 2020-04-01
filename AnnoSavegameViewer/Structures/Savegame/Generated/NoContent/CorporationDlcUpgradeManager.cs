using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CorporationDlcUpgradeManager {

    [BinaryContent(Name = "CheatCount", NodeType = BinaryContentTypes.Node)]
    public CheatCount CheatCount { get; set; }

  }
}