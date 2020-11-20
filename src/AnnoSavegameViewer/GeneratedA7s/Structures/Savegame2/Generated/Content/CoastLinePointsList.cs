namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class CoastLinePointsList {

    #region Public Properties

    [BinaryContent(Name = "pos", NodeType = BinaryContentTypes.Attribute)]
    public object Pos { get; set; }

    [BinaryContent(Name = "dir", NodeType = BinaryContentTypes.Attribute)]
    public object Dir { get; set; }

    #endregion Public Properties
  }
}