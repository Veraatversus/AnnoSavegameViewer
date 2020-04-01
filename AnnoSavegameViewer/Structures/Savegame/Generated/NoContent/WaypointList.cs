using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class WaypointList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<WaypointListList> WaypointListList { get; set; }

  }
}