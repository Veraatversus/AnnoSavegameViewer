using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AIConstructionManager {

    [BinaryContent(Name = "PlannedSettlements", NodeType = BinaryContentTypes.Node)]
    public PlannedSettlements PlannedSettlements { get; set; }

  }
}