using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PlayerCounter {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public Value Value { get; set; }

  }
}