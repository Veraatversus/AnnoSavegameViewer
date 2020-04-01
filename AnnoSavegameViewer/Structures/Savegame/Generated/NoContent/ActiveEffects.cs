using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ActiveEffects {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ActiveEffectsList> ActiveEffectsList { get; set; }

  }
}