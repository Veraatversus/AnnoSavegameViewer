using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class GlobalHistory {

    [BinaryContent(Name = "Snapshots", NodeType = BinaryContentTypes.Node)]
    public Snapshots Snapshots { get; set; }

  }
}