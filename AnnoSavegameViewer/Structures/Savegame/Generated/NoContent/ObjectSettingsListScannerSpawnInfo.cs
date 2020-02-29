using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ObjectSettingsListScannerSpawnInfo {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ObjectSettingsListScannerSpawnInfoList> ObjectSettingsListScannerSpawnInfoList { get; set; }

  }
}