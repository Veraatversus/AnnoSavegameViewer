namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class PlanningGridGridList {

    [BinaryContent(Name = "RandomFreeTile", NodeType = BinaryContentTypes.Attribute)]
    public object RandomFreeTile { get; set; }

    [BinaryContent(Name = "HarborOwner", NodeType = BinaryContentTypes.Attribute)]
    public object HarborOwner { get; set; }

    [BinaryContent(Name = "UnblockedCells", NodeType = BinaryContentTypes.Attribute)]
    public object UnblockedCells { get; set; }

    [BinaryContent(Name = "EdgeReachabilities", NodeType = BinaryContentTypes.Attribute)]
    public object EdgeReachabilities { get; set; }

    [BinaryContent(Name = "State", NodeType = BinaryContentTypes.Attribute)]
    public object State { get; set; }

  }
}