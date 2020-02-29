using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class NextWaypointPath {

    [BinaryContent(Name = "Path", NodeType = BinaryContentTypes.Attribute)]
    public object Path { get; set; }

    [BinaryContent(Name = "AverageSpeed", NodeType = BinaryContentTypes.Attribute)]
    public object AverageSpeed { get; set; }

  }
}