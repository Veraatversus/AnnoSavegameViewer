namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class BridgePath {

    #region Public Properties

    [BinaryContent(Name = "Minimum", NodeType = BinaryContentTypes.Attribute)]
    public object Minimum { get; set; }

    [BinaryContent(Name = "Maximum", NodeType = BinaryContentTypes.Attribute)]
    public object Maximum { get; set; }

    [BinaryContent(Name = "BezierCurve", NodeType = BinaryContentTypes.Node)]
    public BridgePathBezierCurve BezierCurve { get; set; }

    #endregion Public Properties
  }
}