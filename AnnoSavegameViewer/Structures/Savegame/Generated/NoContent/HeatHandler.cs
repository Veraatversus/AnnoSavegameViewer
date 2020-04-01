using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class HeatHandler {

    [BinaryContent(Name = "Heaters", NodeType = BinaryContentTypes.Node)]
    public Heaters Heaters { get; set; }

  }
}