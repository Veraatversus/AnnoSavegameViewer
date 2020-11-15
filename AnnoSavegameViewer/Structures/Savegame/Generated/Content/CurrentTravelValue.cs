namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class CurrentTravelValue {

    #region Public Properties

    [BinaryContent(Name = "Target", NodeType = BinaryContentTypes.Attribute)]
    public object Target { get; set; }

    [BinaryContent(Name = "Origin", NodeType = BinaryContentTypes.Attribute)]
    public object Origin { get; set; }

    #endregion Public Properties
  }
}