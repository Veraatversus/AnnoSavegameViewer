using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Attackers {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<AttackersList> AttackersList { get; set; }

  }
}