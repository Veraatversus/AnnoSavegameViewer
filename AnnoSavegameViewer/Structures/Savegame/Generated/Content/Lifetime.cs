using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Lifetime {

    [BinaryContent(Name = "RemainingTime", NodeType = BinaryContentTypes.Attribute)]
    public object RemainingTime { get; set; }

  }
}