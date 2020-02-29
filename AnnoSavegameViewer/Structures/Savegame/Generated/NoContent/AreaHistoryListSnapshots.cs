using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaHistoryListSnapshots {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<AreaHistoryListSnapshotsList> AreaHistoryListSnapshotsList { get; set; }

  }
}