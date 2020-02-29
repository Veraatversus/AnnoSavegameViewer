using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Collectable {

    #region Public Properties

    [BinaryContent(Name = "Collector", NodeType = BinaryContentTypes.Attribute)]
    public object Collector { get; set; }

    #endregion Public Properties
  }
}