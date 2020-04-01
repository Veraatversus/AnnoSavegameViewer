using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CurrentTravelValue {

    [BinaryContent(Name = "Target", NodeType = BinaryContentTypes.Attribute)]
    public object Target { get; set; }

    [BinaryContent(Name = "Origin", NodeType = BinaryContentTypes.Attribute)]
    public object Origin { get; set; }

  }
}