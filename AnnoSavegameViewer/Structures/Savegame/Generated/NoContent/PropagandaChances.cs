using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PropagandaChances {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<PropagandaChancesList> PropagandaChancesList { get; set; }

  }
}