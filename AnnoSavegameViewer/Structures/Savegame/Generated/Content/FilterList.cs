using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class FilterList {

    [BinaryContent(Name = "FolderID", NodeType = BinaryContentTypes.Attribute)]
    public object FolderID { get; set; }

    [BinaryContent(Name = "DifficultyFlags", NodeType = BinaryContentTypes.Attribute)]
    public object DifficultyFlags { get; set; }

    [BinaryContent(Name = "Filter", NodeType = BinaryContentTypes.Node)]
    public FilterListFilter Filter { get; set; }

  }
}