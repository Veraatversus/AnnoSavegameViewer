namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class GridList {

    #region Public Properties

    [BinaryContent(Name = "FreeTiles", NodeType = BinaryContentTypes.Attribute)]
    public object FreeTiles { get; set; }

    [BinaryContent(Name = "DistanceToBlocker", NodeType = BinaryContentTypes.Attribute)]
    public object DistanceToBlocker { get; set; }

    #endregion Public Properties
  }
}