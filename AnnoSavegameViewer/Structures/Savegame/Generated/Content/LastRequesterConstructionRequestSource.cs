using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class LastRequesterConstructionRequestSource {

    [BinaryContent(Name = "ConstructionRequestSource", NodeType = BinaryContentTypes.Attribute)]
    public object ConstructionRequestSource { get; set; }

  }
}