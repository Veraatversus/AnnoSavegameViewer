using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class OptionalWaypoints {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<OptionalWaypointsList> OptionalWaypointsList { get; set; }

  }
}