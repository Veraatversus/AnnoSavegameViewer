namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class BezierCurve {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<BezierCurveList> BezierCurveList { get; set; }

  }
}