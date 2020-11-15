namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class FilterList {

    #region Public Properties

    [BinaryContent(Name = "FolderID", NodeType = BinaryContentTypes.Attribute)]
    public object FolderID { get; set; }

    [BinaryContent(Name = "DifficultyFlags", NodeType = BinaryContentTypes.Attribute)]
    public object DifficultyFlags { get; set; }

    [BinaryContent(Name = "Filter", NodeType = BinaryContentTypes.Node)]
    public FilterListFilter Filter { get; set; }

    #endregion Public Properties
  }
}