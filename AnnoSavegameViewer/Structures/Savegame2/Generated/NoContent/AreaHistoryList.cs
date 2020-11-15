namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class AreaHistoryList {

    [BinaryContent(Name = "Snapshots", NodeType = BinaryContentTypes.Node)]
    public AreaHistoryListSnapshots Snapshots { get; set; }

  }
}