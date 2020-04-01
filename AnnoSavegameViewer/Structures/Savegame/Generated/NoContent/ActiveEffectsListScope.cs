using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ActiveEffectsListScope {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ActiveEffectsListScopeValue Value { get; set; }

  }
}