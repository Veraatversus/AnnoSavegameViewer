namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class FogsOfWarList {

    #region Public Properties

    [BinaryContent(Name = "LastReHideTime", NodeType = BinaryContentTypes.Attribute)]
    public object LastReHideTime { get; set; }

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public FogsOfWarListValue Value { get; set; }

    [BinaryContent(Name = "DirtyPositions", NodeType = BinaryContentTypes.Node)]
    public DirtyPositions DirtyPositions { get; set; }

    #endregion Public Properties
  }
}