using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class BuildingSolvesList {

    [BinaryContent(Name = "Guid", NodeType = BinaryContentTypes.Attribute)]
    public object Guid { get; set; }

    [BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
    public object AreaID { get; set; }

    [BinaryContent(Name = "Timestamp", NodeType = BinaryContentTypes.Attribute)]
    public object Timestamp { get; set; }

    [BinaryContent(Name = "SessionGUID", NodeType = BinaryContentTypes.Attribute)]
    public object SessionGUID { get; set; }

  }
}