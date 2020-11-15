namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class FOWGrid {

    #region Public Properties

    [BinaryContent(Name = "Width", NodeType = BinaryContentTypes.Attribute)]
    public object Width { get; set; }

    [BinaryContent(Name = "Height", NodeType = BinaryContentTypes.Attribute)]
    public object Height { get; set; }

    [BinaryContent(Name = "bits", NodeType = BinaryContentTypes.Attribute)]
    public object Bits { get; set; }

    #endregion Public Properties
  }
}