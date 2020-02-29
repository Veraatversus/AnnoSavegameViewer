using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CorporationDlcUpgradeManager {

    [BinaryContent(Name = "CheatCount", NodeType = BinaryContentTypes.Node)]
    public CheatCount CheatCount { get; set; }

  }
}