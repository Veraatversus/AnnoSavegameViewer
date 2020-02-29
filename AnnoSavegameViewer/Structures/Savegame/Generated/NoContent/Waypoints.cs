using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Waypoints {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<WaypointsList> WaypointsList { get; set; }

  }
}