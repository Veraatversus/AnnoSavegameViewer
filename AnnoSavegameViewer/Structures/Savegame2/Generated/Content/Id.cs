namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class Id {

    #region Public Properties

    [BinaryContent(Name = "Index", NodeType = BinaryContentTypes.Attribute)]
    public object Index { get; set; }

    [BinaryContent(Name = "ResolverBuilding", NodeType = BinaryContentTypes.Node)]
    public ResolverBuilding ResolverBuilding { get; set; }

    #endregion Public Properties
  }
}