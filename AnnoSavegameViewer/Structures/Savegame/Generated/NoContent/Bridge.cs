using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Bridge {

    [BinaryContent(Name = "Path", NodeType = BinaryContentTypes.Node)]
    public BridgePath Path { get; set; }

    [BinaryContent(Name = "BezierPath", NodeType = BinaryContentTypes.Node)]
    public BridgeBezierPath BezierPath { get; set; }

  }
}