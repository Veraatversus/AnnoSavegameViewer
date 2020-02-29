using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DataBaseNode {

    #region Public Properties

    [BinaryContent(Name = "MetaGameManager", NodeType = BinaryContentTypes.Node)]
    public MetaGameManager MetaGameManager { get; set; }

    #endregion Public Properties
  }
}