using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PropertyPalaceActiveEffectsListScope {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public PropertyPalaceActiveEffectsListScopeValue Value { get; set; }

  }
}