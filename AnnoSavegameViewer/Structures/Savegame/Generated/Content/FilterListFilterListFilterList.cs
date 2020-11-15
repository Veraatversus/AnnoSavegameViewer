namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class FilterListFilterListFilterList {

    #region Public Properties

    [BinaryContent(Name = "FolderID", NodeType = BinaryContentTypes.Attribute)]
    public object FolderID { get; set; }

    [BinaryContent(Name = "Filter", NodeType = BinaryContentTypes.Node)]
    public FilterListFilterListFilterListFilter Filter { get; set; }

    #endregion Public Properties
  }
}