using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CurrentTravelValue {

    #region Public Properties

    [BinaryContent(Name = "Origin", NodeType = BinaryContentTypes.Attribute)]
    public object Origin { get; set; }

    [BinaryContent(Name = "Target", NodeType = BinaryContentTypes.Attribute)]
    public object Target { get; set; }

    #endregion Public Properties
  }
}