namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ItemsList {

    #region Public Properties

    [BinaryContent(Name = "Amount", NodeType = BinaryContentTypes.Attribute)]
    public object Amount { get; set; }

    [BinaryContent(Name = "AssetGUID", NodeType = BinaryContentTypes.Attribute)]
    public object AssetGUID { get; set; }

    #endregion Public Properties
  }
}