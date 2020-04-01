using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CrisisHandler {

    [BinaryContent(Name = "LastTick", NodeType = BinaryContentTypes.Attribute)]
    public object LastTick { get; set; }

    [BinaryContent(Name = "Crises", NodeType = BinaryContentTypes.Node)]
    public Crises Crises { get; set; }

  }
}