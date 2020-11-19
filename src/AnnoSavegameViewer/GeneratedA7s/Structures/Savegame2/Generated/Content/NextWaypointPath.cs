namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class NextWaypointPath {

    [BinaryContent(Name = "Path", NodeType = BinaryContentTypes.Attribute)]
    public object Path { get; set; }

    [BinaryContent(Name = "AverageSpeed", NodeType = BinaryContentTypes.Attribute)]
    public object AverageSpeed { get; set; }

  }
}