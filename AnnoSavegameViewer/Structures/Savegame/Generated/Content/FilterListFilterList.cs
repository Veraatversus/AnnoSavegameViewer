using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class FilterListFilterList {

    [BinaryContent(Name = "FolderID", NodeType = BinaryContentTypes.Attribute)]
    public object FolderID { get; set; }

    [BinaryContent(Name = "Filter", NodeType = BinaryContentTypes.Node)]
    public FilterListFilterListFilter Filter { get; set; }

  }
}