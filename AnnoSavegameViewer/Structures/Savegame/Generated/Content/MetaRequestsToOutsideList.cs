using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MetaRequestsToOutsideList {

    [BinaryContent(Name = "Product", NodeType = BinaryContentTypes.Attribute)]
    public object Product { get; set; }

    [BinaryContent(Name = "Priority", NodeType = BinaryContentTypes.Node)]
    public MetaRequestsToOutsideListPriority Priority { get; set; }

    [BinaryContent(Name = "Source", NodeType = BinaryContentTypes.Node)]
    public MetaRequestsToOutsideListSource Source { get; set; }

  }
}