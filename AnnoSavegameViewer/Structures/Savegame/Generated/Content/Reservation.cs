using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Reservation {

    [BinaryContent(Name = "Position", NodeType = BinaryContentTypes.Attribute)]
    public object Position { get; set; }

    [BinaryContent(Name = "RectSize", NodeType = BinaryContentTypes.Attribute)]
    public object RectSize { get; set; }

    [BinaryContent(Name = "Direction", NodeType = BinaryContentTypes.Attribute)]
    public object Direction { get; set; }

  }
}