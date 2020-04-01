using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaRandomManager {

    [BinaryContent(Name = "netsafeRandom", NodeType = BinaryContentTypes.Node)]
    public NetsafeRandom NetsafeRandom { get; set; }

  }
}