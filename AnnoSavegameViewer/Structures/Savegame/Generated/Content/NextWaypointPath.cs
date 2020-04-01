using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class NextWaypointPath {

    [BinaryContent(Name = "Path", NodeType = BinaryContentTypes.Attribute)]
    public object Path { get; set; }

    [BinaryContent(Name = "AverageSpeed", NodeType = BinaryContentTypes.Attribute)]
    public object AverageSpeed { get; set; }

  }
}