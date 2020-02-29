using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Collector {

    #region Public Properties

    [BinaryContent(Name = "SonarGUID", NodeType = BinaryContentTypes.Attribute)]
    public object SonarGUID { get; set; }

    [BinaryContent(Name = "Collected", NodeType = BinaryContentTypes.Node)]
    public Collected Collected { get; set; }

    #endregion Public Properties
  }
}