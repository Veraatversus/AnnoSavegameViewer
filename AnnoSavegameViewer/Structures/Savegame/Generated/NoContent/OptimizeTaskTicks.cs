using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class OptimizeTaskTicks {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<OptimizeTaskTicksList> OptimizeTaskTicksList { get; set; }

  }
}