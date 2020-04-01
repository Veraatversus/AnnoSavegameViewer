using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ActiveEffectsListDistanceSource {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ActiveEffectsListDistanceSourceValue Value { get; set; }

  }
}