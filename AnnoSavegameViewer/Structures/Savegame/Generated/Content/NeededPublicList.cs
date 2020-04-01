using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class NeededPublicList {

    [BinaryContent(Name = "PublicGUID", NodeType = BinaryContentTypes.Attribute)]
    public object PublicGUID { get; set; }

    [BinaryContent(Name = "Covered", NodeType = BinaryContentTypes.Attribute)]
    public object Covered { get; set; }

    [BinaryContent(Name = "Required", NodeType = BinaryContentTypes.Attribute)]
    public object Required { get; set; }

    [BinaryContent(Name = "Blocked", NodeType = BinaryContentTypes.Attribute)]
    public object Blocked { get; set; }

  }
}