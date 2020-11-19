namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class FilterListFilterList {

    #region Public Properties

    [BinaryContent(Name = "FolderID", NodeType = BinaryContentTypes.Attribute)]
    public object FolderID { get; set; }

    [BinaryContent(Name = "Filter", NodeType = BinaryContentTypes.Node)]
    public FilterListFilterListFilter Filter { get; set; }

    #endregion Public Properties
  }
}