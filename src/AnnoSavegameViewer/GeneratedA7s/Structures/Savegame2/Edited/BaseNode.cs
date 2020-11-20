namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class DataBaseNode {

    #region Public Properties

    [BinaryContent(Name = "MetaGameManager", NodeType = BinaryContentTypes.Node)]
    public MetaGameManager MetaGameManager { get; set; }

    #endregion Public Properties
  }
}