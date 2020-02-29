using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Factory7ProductionState {

    [BinaryContent(Name = "RemainingTime", NodeType = BinaryContentTypes.Attribute)]
    public object RemainingTime { get; set; }

    [BinaryContent(Name = "Productivity", NodeType = BinaryContentTypes.Attribute)]
    public object Productivity { get; set; }

    [BinaryContent(Name = "InProgress", NodeType = BinaryContentTypes.Attribute)]
    public object InProgress { get; set; }

  }
}