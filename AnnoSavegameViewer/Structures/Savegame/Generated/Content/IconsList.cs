namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class IconsList {

    #region Public Properties

    [BinaryContent(Name = "VisibilityMaskNew", NodeType = BinaryContentTypes.Attribute)]
    public object VisibilityMaskNew { get; set; }

    [BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
    public object GUID { get; set; }

    [BinaryContent(Name = "ShowTime", NodeType = BinaryContentTypes.Attribute)]
    public object ShowTime { get; set; }

    [BinaryContent(Name = "HadCallback", NodeType = BinaryContentTypes.Attribute)]
    public object HadCallback { get; set; }

    #endregion Public Properties
  }
}