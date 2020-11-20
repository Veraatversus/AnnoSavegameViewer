namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ItemTrade {

    #region Public Properties

    [BinaryContent(Name = "LastReroll", NodeType = BinaryContentTypes.Attribute)]
    public object LastReroll { get; set; }

    [BinaryContent(Name = "Items", NodeType = BinaryContentTypes.Node)]
    public Items Items { get; set; }

    #endregion Public Properties
  }
}