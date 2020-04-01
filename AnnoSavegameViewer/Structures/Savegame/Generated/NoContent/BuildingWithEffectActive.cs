using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class BuildingWithEffectActive {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<BuildingWithEffectActiveList> BuildingWithEffectActiveList { get; set; }

  }
}