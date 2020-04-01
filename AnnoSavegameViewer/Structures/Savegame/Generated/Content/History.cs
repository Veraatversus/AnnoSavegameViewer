using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class History {

    [BinaryContent(Name = "lastSnapshot", NodeType = BinaryContentTypes.Attribute)]
    public object LastSnapshot { get; set; }

    [BinaryContent(Name = "globalHistory", NodeType = BinaryContentTypes.Node)]
    public GlobalHistory GlobalHistory { get; set; }

    [BinaryContent(Name = "areaHistory", NodeType = BinaryContentTypes.Node)]
    public AreaHistory AreaHistory { get; set; }

  }
}