namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ConditionsListDemandedGoodsList {

    #region Public Properties

    [BinaryContent(Name = "ProductGuid", NodeType = BinaryContentTypes.Attribute)]
    public object ProductGuid { get; set; }

    [BinaryContent(Name = "ProductAmount", NodeType = BinaryContentTypes.Attribute)]
    public object ProductAmount { get; set; }

    [BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Node)]
    public ConditionsListDemandedGoodsListQuestID QuestID { get; set; }

    #endregion Public Properties
  }
}