namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class OptimalAttackMovementData {

    [BinaryContent(Name = "OptimalAngleWS", NodeType = BinaryContentTypes.Attribute)]
    public object OptimalAngleWS { get; set; }

    [BinaryContent(Name = "OptimalDistanceWS", NodeType = BinaryContentTypes.Attribute)]
    public object OptimalDistanceWS { get; set; }

  }
}