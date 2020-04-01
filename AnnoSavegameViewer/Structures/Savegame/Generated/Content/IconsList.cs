using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class IconsList {

    [BinaryContent(Name = "VisibilityMaskNew", NodeType = BinaryContentTypes.Attribute)]
    public object VisibilityMaskNew { get; set; }

    [BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
    public object GUID { get; set; }

    [BinaryContent(Name = "ShowTime", NodeType = BinaryContentTypes.Attribute)]
    public object ShowTime { get; set; }

    [BinaryContent(Name = "HadCallback", NodeType = BinaryContentTypes.Attribute)]
    public object HadCallback { get; set; }

  }
}