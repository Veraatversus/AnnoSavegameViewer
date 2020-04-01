using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class GrowingMapList {

    [BinaryContent(Name = "growingStart", NodeType = BinaryContentTypes.Attribute)]
    public object GrowingStart { get; set; }

    [BinaryContent(Name = "growingDuration", NodeType = BinaryContentTypes.Attribute)]
    public object GrowingDuration { get; set; }

    [BinaryContent(Name = "growingSize", NodeType = BinaryContentTypes.Attribute)]
    public object GrowingSize { get; set; }

  }
}