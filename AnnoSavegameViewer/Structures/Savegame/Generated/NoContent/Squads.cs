using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Squads {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<SquadsList> SquadsList { get; set; }

  }
}