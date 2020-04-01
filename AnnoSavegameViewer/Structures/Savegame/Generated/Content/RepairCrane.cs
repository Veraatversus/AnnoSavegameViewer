using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class RepairCrane {

    [BinaryContent(Name = "currentRepairTarget", NodeType = BinaryContentTypes.Attribute)]
    public object CurrentRepairTarget { get; set; }

  }
}