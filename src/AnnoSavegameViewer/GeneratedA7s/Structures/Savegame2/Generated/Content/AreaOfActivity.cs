namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class AreaOfActivity {

    #region Public Properties

    [BinaryContent(Name = "ptCenter", NodeType = BinaryContentTypes.Attribute)]
    public object PtCenter { get; set; }

    [BinaryContent(Name = "Radius", NodeType = BinaryContentTypes.Attribute)]
    public object Radius { get; set; }

    #endregion Public Properties
  }
}