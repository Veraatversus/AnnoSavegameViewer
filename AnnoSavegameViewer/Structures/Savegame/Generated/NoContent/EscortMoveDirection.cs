using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class EscortMoveDirection {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public EscortMoveDirectionValue Value { get; set; }

  }
}