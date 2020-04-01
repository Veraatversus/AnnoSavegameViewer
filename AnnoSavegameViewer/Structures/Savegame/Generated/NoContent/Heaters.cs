using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Heaters {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<HeatersList> HeatersList { get; set; }

  }
}