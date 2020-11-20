namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class PriorityHandler {

    [BinaryContent(Name = "ProductionCount", NodeType = BinaryContentTypes.Attribute)]
    public object ProductionCount { get; set; }

    [BinaryContent(Name = "Prios", NodeType = BinaryContentTypes.Node)]
    public Prios Prios { get; set; }

  }
}