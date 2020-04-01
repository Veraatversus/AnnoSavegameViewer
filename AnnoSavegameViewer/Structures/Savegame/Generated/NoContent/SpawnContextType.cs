using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SpawnContextType {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public SpawnContextTypeValue Value { get; set; }

  }
}