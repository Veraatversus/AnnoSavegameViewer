namespace AnnoSavegameViewer.Templates {
  using AnnoSavegameViewer.Structures.Savegame.Generated;

  public class Savegame {

    #region Public Properties

    public string FilePath { get; set; }
    public DataBaseNode Data { get; set; }
    public AnnoGameObjects GameObjects { get; internal set; }

    #endregion Public Properties
  }
}