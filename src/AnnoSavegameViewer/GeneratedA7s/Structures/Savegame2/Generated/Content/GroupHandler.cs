namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class GroupHandler {

    #region Public Properties

    [BinaryContent(Name = "NextGroupID", NodeType = BinaryContentTypes.Attribute)]
    public object NextGroupID { get; set; }

    [BinaryContent(Name = "Groups", NodeType = BinaryContentTypes.Node)]
    public Groups Groups { get; set; }

    #endregion Public Properties
  }
}