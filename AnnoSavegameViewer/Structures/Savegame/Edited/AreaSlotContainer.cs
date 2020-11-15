namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class AreaSlotContainer {

    #region Public Properties

    [BinaryContent(Name = "UnlimitedSlotCount", NodeType = BinaryContentTypes.Attribute)]
    public object UnlimitedSlotCount { get; set; }

    [BinaryContent(Name = "UnlimitedStack", NodeType = BinaryContentTypes.Attribute)]
    public object UnlimitedStack { get; set; }

    [BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
    public short AreaID { get; set; }

    [BinaryContent(Name = "SlotList", NodeType = BinaryContentTypes.Node)]
    public AreaSlotContainerSlotList SlotList { get; set; }

    #endregion Public Properties
  }
}