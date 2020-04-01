using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CivLevel {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public CivLevelValue Value { get; set; }

  }
}