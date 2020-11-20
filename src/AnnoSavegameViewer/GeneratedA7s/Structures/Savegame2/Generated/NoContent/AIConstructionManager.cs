namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class AIConstructionManager {

    [BinaryContent(Name = "PlannedSettlements", NodeType = BinaryContentTypes.Node)]
    public PlannedSettlements PlannedSettlements { get; set; }

  }
}