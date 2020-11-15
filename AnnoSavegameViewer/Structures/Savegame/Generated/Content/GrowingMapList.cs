namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class GrowingMapList {

    #region Public Properties

    [BinaryContent(Name = "growingStart", NodeType = BinaryContentTypes.Attribute)]
    public object GrowingStart { get; set; }

    [BinaryContent(Name = "growingDuration", NodeType = BinaryContentTypes.Attribute)]
    public object GrowingDuration { get; set; }

    [BinaryContent(Name = "growingSize", NodeType = BinaryContentTypes.Attribute)]
    public object GrowingSize { get; set; }

    #endregion Public Properties
  }
}