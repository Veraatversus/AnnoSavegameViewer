namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class DiplomacyStatesList {

    #region Public Properties

    [BinaryContent(Name = "ExpireTimestamp", NodeType = BinaryContentTypes.Attribute)]
    public object ExpireTimestamp { get; set; }

    [BinaryContent(Name = "FullTime", NodeType = BinaryContentTypes.Attribute)]
    public object FullTime { get; set; }

    [BinaryContent(Name = "State", NodeType = BinaryContentTypes.Node)]
    public State State { get; set; }

    #endregion Public Properties
  }
}