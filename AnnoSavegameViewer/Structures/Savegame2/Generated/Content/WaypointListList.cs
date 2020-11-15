namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class WaypointListList {

    [BinaryContent(Name = "TimeToTarget", NodeType = BinaryContentTypes.Attribute)]
    public object TimeToTarget { get; set; }

    [BinaryContent(Name = "TargetObject", NodeType = BinaryContentTypes.Node)]
    public WaypointListListTargetObject TargetObject { get; set; }

  }
}