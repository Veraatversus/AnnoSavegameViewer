using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class BridgePathBezierCurveList {

    #region Public Properties

    [BinaryContent(Name = "p", NodeType = BinaryContentTypes.Attribute)]
    public object P { get; set; }

    [BinaryContent(Name = "i", NodeType = BinaryContentTypes.Attribute)]
    public object I { get; set; }

    [BinaryContent(Name = "o", NodeType = BinaryContentTypes.Attribute)]
    public object O { get; set; }

    #endregion Public Properties
  }
}