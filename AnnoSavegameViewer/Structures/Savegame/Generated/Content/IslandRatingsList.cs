using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class IslandRatingsList {

    [BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
    public object AreaID { get; set; }

    [BinaryContent(Name = "Category", NodeType = BinaryContentTypes.Attribute)]
    public object Category { get; set; }

    [BinaryContent(Name = "Priority", NodeType = BinaryContentTypes.Attribute)]
    public object Priority { get; set; }

  }
}