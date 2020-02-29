using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class TrainStationWaypointList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<TrainStationWaypointListList> TrainStationWaypointListList { get; set; }

  }
}