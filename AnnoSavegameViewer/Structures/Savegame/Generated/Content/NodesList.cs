using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class NodesList {

    [BinaryContent(Name = "Position", NodeType = BinaryContentTypes.Attribute)]
    public object Position { get; set; }

    [BinaryContent(Name = "IsPersistent", NodeType = BinaryContentTypes.Attribute)]
    public object IsPersistent { get; set; }

  }
}