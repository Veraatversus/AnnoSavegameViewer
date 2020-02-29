using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class BridgeBezierPathBezierCurve {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<BridgeBezierPathBezierCurveList> BridgeBezierPathBezierCurveList { get; set; }

  }
}