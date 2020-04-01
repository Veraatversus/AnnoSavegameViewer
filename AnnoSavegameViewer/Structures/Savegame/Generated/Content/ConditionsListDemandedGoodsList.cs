using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ConditionsListDemandedGoodsList {

    [BinaryContent(Name = "ProductGuid", NodeType = BinaryContentTypes.Attribute)]
    public object ProductGuid { get; set; }

    [BinaryContent(Name = "ProductAmount", NodeType = BinaryContentTypes.Attribute)]
    public object ProductAmount { get; set; }

    [BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Node)]
    public ConditionsListDemandedGoodsListQuestID QuestID { get; set; }

  }
}