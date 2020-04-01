using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class BridgeBezierPath {

    [BinaryContent(Name = "Minimum", NodeType = BinaryContentTypes.Attribute)]
    public object Minimum { get; set; }

    [BinaryContent(Name = "Maximum", NodeType = BinaryContentTypes.Attribute)]
    public object Maximum { get; set; }

    [BinaryContent(Name = "BezierCurve", NodeType = BinaryContentTypes.Node)]
    public BridgeBezierPathBezierCurve BezierCurve { get; set; }

  }
}