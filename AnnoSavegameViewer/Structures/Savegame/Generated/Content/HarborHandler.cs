using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class HarborHandler {

    [BinaryContent(Name = "SecurityFactor", NodeType = BinaryContentTypes.Attribute)]
    public object SecurityFactor { get; set; }

  }
}