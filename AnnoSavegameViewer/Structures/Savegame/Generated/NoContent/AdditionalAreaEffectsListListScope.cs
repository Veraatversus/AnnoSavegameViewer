using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AdditionalAreaEffectsListListScope {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public AdditionalAreaEffectsListListScopeValue Value { get; set; }

  }
}