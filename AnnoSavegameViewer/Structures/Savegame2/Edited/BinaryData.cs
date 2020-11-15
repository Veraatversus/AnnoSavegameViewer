namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class BinaryData {

    #region Public Properties

    [BinaryContent(Name = "SessionFileVersion", NodeType = BinaryContentTypes.Attribute)]
    public int SessionFileVersion { get; set; }

    [BinaryContent(Name = "GameSessionManager", NodeType = BinaryContentTypes.Node)]
    public GameSessionManager GameSessionManager { get; set; }

    #endregion Public Properties
  }
}