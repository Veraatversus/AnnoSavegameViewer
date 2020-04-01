using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DaytimeManager {

    [BinaryContent(Name = "DaytimeSetting", NodeType = BinaryContentTypes.Node)]
    public DaytimeSetting DaytimeSetting { get; set; }

  }
}