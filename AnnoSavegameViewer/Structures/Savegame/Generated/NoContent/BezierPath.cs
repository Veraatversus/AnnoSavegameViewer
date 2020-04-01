using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class BezierPath {

    [BinaryContent(Name = "Path", NodeType = BinaryContentTypes.Node)]
    public Path Path { get; set; }

  }
}