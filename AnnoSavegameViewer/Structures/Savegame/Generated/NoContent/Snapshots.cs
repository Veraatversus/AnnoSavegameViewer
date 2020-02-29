using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Snapshots {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<SnapshotsList> SnapshotsList { get; set; }

  }
}