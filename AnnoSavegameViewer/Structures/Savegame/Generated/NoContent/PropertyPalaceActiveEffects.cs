using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PropertyPalaceActiveEffects {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<PropertyPalaceActiveEffectsList> PropertyPalaceActiveEffectsList { get; set; }

  }
}