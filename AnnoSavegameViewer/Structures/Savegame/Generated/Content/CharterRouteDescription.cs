namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class CharterRouteDescription {

    #region Public Properties

    [BinaryContent(Name = "SourceArea", NodeType = BinaryContentTypes.Attribute)]
    public object SourceArea { get; set; }

    [BinaryContent(Name = "TargetArea", NodeType = BinaryContentTypes.Attribute)]
    public object TargetArea { get; set; }

    #endregion Public Properties
  }
}