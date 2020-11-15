namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class Path {

    [BinaryContent(Name = "Minimum", NodeType = BinaryContentTypes.Attribute)]
    public object Minimum { get; set; }

    [BinaryContent(Name = "Maximum", NodeType = BinaryContentTypes.Attribute)]
    public object Maximum { get; set; }

    [BinaryContent(Name = "TangentScale", NodeType = BinaryContentTypes.Attribute)]
    public object TangentScale { get; set; }

    [BinaryContent(Name = "BezierCurve", NodeType = BinaryContentTypes.Node)]
    public BezierCurve BezierCurve { get; set; }

  }
}