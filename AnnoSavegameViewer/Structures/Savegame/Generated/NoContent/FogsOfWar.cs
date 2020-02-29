using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class FogsOfWar {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<FogsOfWarList> FogsOfWarList { get; set; }

  }
}