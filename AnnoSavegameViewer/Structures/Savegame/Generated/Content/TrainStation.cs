using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class TrainStation {

    [BinaryContent(Name = "LastTrainSend", NodeType = BinaryContentTypes.Attribute)]
    public object LastTrainSend { get; set; }

    [BinaryContent(Name = "m_EarliestTrain", NodeType = BinaryContentTypes.Attribute)]
    public object M_EarliestTrain { get; set; }

    [BinaryContent(Name = "m_LoadCapacity", NodeType = BinaryContentTypes.Attribute)]
    public object M_LoadCapacity { get; set; }

    [BinaryContent(Name = "WaypointList", NodeType = BinaryContentTypes.Node)]
    public TrainStationWaypointList WaypointList { get; set; }

    [BinaryContent(Name = "BlockedTrainInfos", NodeType = BinaryContentTypes.Node)]
    public BlockedTrainInfos BlockedTrainInfos { get; set; }

  }
}