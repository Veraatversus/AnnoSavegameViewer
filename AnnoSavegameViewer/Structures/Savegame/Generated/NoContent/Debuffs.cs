using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Debuffs {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<DebuffsList> DebuffsList { get; set; }

  }
}