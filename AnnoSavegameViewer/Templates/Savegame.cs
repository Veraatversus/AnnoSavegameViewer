namespace AnnoSavegameViewer.Templates {
  using AnnoSerializer.Structures.Generated.a7s;

  public class Savegame {

    #region Public Properties

    public string FilePath { get; set; }
    public A7s_File Data { get; set; }
    public AnnoGameObjects GameObjects { get; internal set; }

    #endregion Public Properties
  }
}