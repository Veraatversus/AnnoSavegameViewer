using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Stations {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<StationsList> StationsList { get; set; }

  }
}