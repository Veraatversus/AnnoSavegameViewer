namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class DemandedGoodsList {

    #region Public Properties

    [BinaryContent(Name = "ProductGuid", NodeType = BinaryContentTypes.Attribute)]
    public object ProductGuid { get; set; }

    [BinaryContent(Name = "ProductAmount", NodeType = BinaryContentTypes.Attribute)]
    public object ProductAmount { get; set; }

    [BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Node)]
    public QuestID QuestID { get; set; }

    #endregion Public Properties
  }
}