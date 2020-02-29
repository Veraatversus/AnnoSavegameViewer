using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class BezierCurve {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<BezierCurveList> BezierCurveList { get; set; }

  }
}