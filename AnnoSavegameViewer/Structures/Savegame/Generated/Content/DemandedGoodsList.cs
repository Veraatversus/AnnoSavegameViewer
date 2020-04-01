using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DemandedGoodsList {

    [BinaryContent(Name = "ProductGuid", NodeType = BinaryContentTypes.Attribute)]
    public object ProductGuid { get; set; }

    [BinaryContent(Name = "ProductAmount", NodeType = BinaryContentTypes.Attribute)]
    public object ProductAmount { get; set; }

    [BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Node)]
    public QuestID QuestID { get; set; }

  }
}