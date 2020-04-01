using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DestroySpawnInfo {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<DestroySpawnInfoList> DestroySpawnInfoList { get; set; }

  }
}