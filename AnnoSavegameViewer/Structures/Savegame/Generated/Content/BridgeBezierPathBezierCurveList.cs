using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class BridgeBezierPathBezierCurveList {

    [BinaryContent(Name = "p", NodeType = BinaryContentTypes.Attribute)]
    public object P { get; set; }

    [BinaryContent(Name = "i", NodeType = BinaryContentTypes.Attribute)]
    public object I { get; set; }

    [BinaryContent(Name = "o", NodeType = BinaryContentTypes.Attribute)]
    public object O { get; set; }

  }
}