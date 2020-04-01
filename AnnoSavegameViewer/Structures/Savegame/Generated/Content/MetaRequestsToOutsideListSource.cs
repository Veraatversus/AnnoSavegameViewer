using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MetaRequestsToOutsideListSource {

    [BinaryContent(Name = "Source", NodeType = BinaryContentTypes.Attribute)]
    public object Source { get; set; }

  }
}