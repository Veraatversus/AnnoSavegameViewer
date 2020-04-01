using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Target {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public TargetValue Value { get; set; }

  }
}