using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PlannedSettlementsList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public PlannedSettlementsListValue Value { get; set; }

  }
}