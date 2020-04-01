using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaHistoryList {

    [BinaryContent(Name = "Snapshots", NodeType = BinaryContentTypes.Node)]
    public AreaHistoryListSnapshots Snapshots { get; set; }

  }
}