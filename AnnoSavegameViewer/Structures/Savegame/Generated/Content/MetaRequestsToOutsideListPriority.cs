using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MetaRequestsToOutsideListPriority {

    [BinaryContent(Name = "Priority", NodeType = BinaryContentTypes.Attribute)]
    public object Priority { get; set; }

  }
}