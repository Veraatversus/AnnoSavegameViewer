namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class GlobalHistory {

    [BinaryContent(Name = "Snapshots", NodeType = BinaryContentTypes.Node)]
    public Snapshots Snapshots { get; set; }

  }
}