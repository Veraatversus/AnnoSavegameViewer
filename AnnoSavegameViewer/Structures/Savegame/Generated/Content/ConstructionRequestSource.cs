using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ConstructionRequestSource {

    [BinaryContent(Name = "ConstructionRequestSource", NodeType = BinaryContentTypes.Attribute)]
    public object ConstructionRequestSourceItem { get; set; }

  }
}