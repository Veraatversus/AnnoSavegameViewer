using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class OptimizeTasks {

    [BinaryContent(Name = "OptimizeRequests", NodeType = BinaryContentTypes.Node)]
    public OptimizeRequests OptimizeRequests { get; set; }

  }
}