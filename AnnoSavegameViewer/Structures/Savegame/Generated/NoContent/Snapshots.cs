namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class Snapshots {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<SnapshotsList> SnapshotsList { get; set; }

  }
}