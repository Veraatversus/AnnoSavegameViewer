namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class History {

    #region Public Properties

    [BinaryContent(Name = "lastSnapshot", NodeType = BinaryContentTypes.Attribute)]
    public object LastSnapshot { get; set; }

    [BinaryContent(Name = "globalHistory", NodeType = BinaryContentTypes.Node)]
    public GlobalHistory GlobalHistory { get; set; }

    [BinaryContent(Name = "areaHistory", NodeType = BinaryContentTypes.Node)]
    public AreaHistory AreaHistory { get; set; }

    #endregion Public Properties
  }
}