namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class EnterSessionMission {

    #region Public Properties

    [BinaryContent(Name = "PendingMission", NodeType = BinaryContentTypes.Attribute)]
    public object PendingMission { get; set; }

    #endregion Public Properties
  }
}