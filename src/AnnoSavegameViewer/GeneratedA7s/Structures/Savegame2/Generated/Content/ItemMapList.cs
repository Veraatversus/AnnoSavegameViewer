namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ItemMapList {

    #region Public Properties

    [BinaryContent(Name = "ItemID", NodeType = BinaryContentTypes.Attribute)]
    public object ItemID { get; set; }

    [BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
    public object GUID { get; set; }

    [BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Attribute)]
    public object QuestID { get; set; }

    [BinaryContent(Name = "Charges", NodeType = BinaryContentTypes.Attribute)]
    public object Charges { get; set; }

    #endregion Public Properties
  }
}