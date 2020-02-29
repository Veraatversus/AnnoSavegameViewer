using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ScannerSpawnInfo {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ScannerSpawnInfoList> ScannerSpawnInfoList { get; set; }

  }
}