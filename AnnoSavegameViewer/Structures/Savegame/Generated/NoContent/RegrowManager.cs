namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class RegrowManager {

    [BinaryContent(Name = "TreeMap", NodeType = BinaryContentTypes.Node)]
    public TreeMap TreeMap { get; set; }

    [BinaryContent(Name = "CreatedTreeMap", NodeType = BinaryContentTypes.Node)]
    public CreatedTreeMap CreatedTreeMap { get; set; }

    [BinaryContent(Name = "GrowingMap", NodeType = BinaryContentTypes.Node)]
    public GrowingMap GrowingMap { get; set; }

  }
}