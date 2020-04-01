using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AdditionalSessionEffects {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<AdditionalSessionEffectsList> AdditionalSessionEffectsList { get; set; }

  }
}