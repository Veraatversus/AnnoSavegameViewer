using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class VerticalEdgesListListOccupyTimesList {

    [BinaryContent(Name = "TrainID", NodeType = BinaryContentTypes.Attribute)]
    public object TrainID { get; set; }

    [BinaryContent(Name = "EnterTime", NodeType = BinaryContentTypes.Attribute)]
    public object EnterTime { get; set; }

    [BinaryContent(Name = "LeaveTime", NodeType = BinaryContentTypes.Attribute)]
    public object LeaveTime { get; set; }

    [BinaryContent(Name = "TrainOwner", NodeType = BinaryContentTypes.Node)]
    public VerticalEdgesListListOccupyTimesListTrainOwner TrainOwner { get; set; }

  }
}