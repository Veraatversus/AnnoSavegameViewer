using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AIConstructionManager {

    [BinaryContent(Name = "PlannedSettlements", NodeType = BinaryContentTypes.Node)]
    public PlannedSettlements PlannedSettlements { get; set; }

  }
}