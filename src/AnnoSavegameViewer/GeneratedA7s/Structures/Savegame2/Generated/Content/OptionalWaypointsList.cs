namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class OptionalWaypointsList {

    [BinaryContent(Name = "TimeToTarget", NodeType = BinaryContentTypes.Attribute)]
    public object TimeToTarget { get; set; }

    [BinaryContent(Name = "TargetObject", NodeType = BinaryContentTypes.Node)]
    public OptionalWaypointsListTargetObject TargetObject { get; set; }

  }
}