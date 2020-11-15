namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class CurrentMinesList {

    #region Public Properties

    [BinaryContent(Name = "pos", NodeType = BinaryContentTypes.Attribute)]
    public object Pos { get; set; }

    [BinaryContent(Name = "area", NodeType = BinaryContentTypes.Attribute)]
    public object Area { get; set; }

    #endregion Public Properties
  }
}