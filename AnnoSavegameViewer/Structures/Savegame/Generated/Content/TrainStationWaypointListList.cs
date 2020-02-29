using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class TrainStationWaypointListList {

    [BinaryContent(Name = "TimeToTarget", NodeType = BinaryContentTypes.Attribute)]
    public object TimeToTarget { get; set; }

    [BinaryContent(Name = "TargetObject", NodeType = BinaryContentTypes.Node)]
    public TrainStationWaypointListListTargetObject TargetObject { get; set; }

  }
}