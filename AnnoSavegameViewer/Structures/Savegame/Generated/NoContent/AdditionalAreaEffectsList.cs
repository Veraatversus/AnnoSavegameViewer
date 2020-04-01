using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AdditionalAreaEffectsList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<AdditionalAreaEffectsListList> AdditionalAreaEffectsListList { get; set; }

  }
}