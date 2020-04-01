using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ArchiveListListTextInfoList {

    [BinaryContent(Name = "type", NodeType = BinaryContentTypes.Attribute)]
    public object Type { get; set; }

    [BinaryContent(Name = "valArea", NodeType = BinaryContentTypes.Attribute)]
    public object ValArea { get; set; }

    [BinaryContent(Name = "valInt", NodeType = BinaryContentTypes.Attribute)]
    public object ValInt { get; set; }

    [BinaryContent(Name = "valObj", NodeType = BinaryContentTypes.Node)]
    public ValObj ValObj { get; set; }

  }
}