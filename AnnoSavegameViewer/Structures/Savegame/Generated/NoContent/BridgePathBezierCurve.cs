using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class BridgePathBezierCurve {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<BridgePathBezierCurveList> BridgePathBezierCurveList { get; set; }

  }
}