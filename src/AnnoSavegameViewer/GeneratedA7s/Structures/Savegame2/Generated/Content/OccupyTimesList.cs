namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class OccupyTimesList {

    [BinaryContent(Name = "TrainID", NodeType = BinaryContentTypes.Attribute)]
    public object TrainID { get; set; }

    [BinaryContent(Name = "EnterTime", NodeType = BinaryContentTypes.Attribute)]
    public object EnterTime { get; set; }

    [BinaryContent(Name = "LeaveTime", NodeType = BinaryContentTypes.Attribute)]
    public object LeaveTime { get; set; }

    [BinaryContent(Name = "TrainOwner", NodeType = BinaryContentTypes.Node)]
    public TrainOwner TrainOwner { get; set; }

  }
}