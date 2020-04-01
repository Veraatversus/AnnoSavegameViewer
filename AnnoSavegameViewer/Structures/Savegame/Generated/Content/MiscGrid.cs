using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MiscGrid {

    [BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
    public object AreaID { get; set; }

    [BinaryContent(Name = "Origin", NodeType = BinaryContentTypes.Attribute)]
    public object Origin { get; set; }

    [BinaryContent(Name = "Max", NodeType = BinaryContentTypes.Attribute)]
    public object Max { get; set; }

    [BinaryContent(Name = "Dimensions", NodeType = BinaryContentTypes.Attribute)]
    public object Dimensions { get; set; }

    [BinaryContent(Name = "MiscGridData", NodeType = BinaryContentTypes.Attribute)]
    public object MiscGridData { get; set; }

  }
}