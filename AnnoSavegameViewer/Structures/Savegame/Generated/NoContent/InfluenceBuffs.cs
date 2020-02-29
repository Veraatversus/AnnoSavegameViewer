using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class InfluenceBuffs {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<InfluenceBuffsList> InfluenceBuffsList { get; set; }

  }
}