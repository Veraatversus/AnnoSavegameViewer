using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class M_IslandPriorities {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<M_IslandPrioritiesList> M_IslandPrioritiesList { get; set; }

  }
}