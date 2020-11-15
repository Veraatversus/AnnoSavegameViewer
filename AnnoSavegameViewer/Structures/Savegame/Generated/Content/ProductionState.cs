namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ProductionState {

    [BinaryContent(Name = "InProgress", NodeType = BinaryContentTypes.Attribute)]
    public object InProgress { get; set; }

    [BinaryContent(Name = "RemainingTime", NodeType = BinaryContentTypes.Attribute)]
    public object RemainingTime { get; set; }

    [BinaryContent(Name = "Productivity", NodeType = BinaryContentTypes.Attribute)]
    public object Productivity { get; set; }

  }
}