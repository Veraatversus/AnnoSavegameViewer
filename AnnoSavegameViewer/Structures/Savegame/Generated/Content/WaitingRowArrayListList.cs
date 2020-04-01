using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class WaitingRowArrayListList {

    [BinaryContent(Name = "Position", NodeType = BinaryContentTypes.Attribute)]
    public object Position { get; set; }

    [BinaryContent(Name = "InUse", NodeType = BinaryContentTypes.Attribute)]
    public object InUse { get; set; }

  }
}