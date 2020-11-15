namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class SlotContainerSlotListList {

    #region Public Properties

    [BinaryContent(Name = "ProductStackSize", NodeType = BinaryContentTypes.Attribute)]
    public int ProductStackSize { get; set; }

    [BinaryContent(Name = "Stack", NodeType = BinaryContentTypes.Node)]
    public Stack Stack { get; set; }

    #endregion Public Properties
  }
}