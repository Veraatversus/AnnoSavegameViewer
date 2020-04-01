using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Decree {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public DecreeValue Value { get; set; }

  }
}