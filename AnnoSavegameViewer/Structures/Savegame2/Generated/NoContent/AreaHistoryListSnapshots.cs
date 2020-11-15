namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class AreaHistoryListSnapshots {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<AreaHistoryListSnapshotsList> AreaHistoryListSnapshotsList { get; set; }

  }
}