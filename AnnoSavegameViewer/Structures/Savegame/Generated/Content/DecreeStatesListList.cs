namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class DecreeStatesListList {

    #region Public Properties

    [BinaryContent(Name = "UnlockedState", NodeType = BinaryContentTypes.Attribute)]
    public object UnlockedState { get; set; }

    [BinaryContent(Name = "FirstTimeUnlockAcknowledgedState", NodeType = BinaryContentTypes.Attribute)]
    public object FirstTimeUnlockAcknowledgedState { get; set; }

    #endregion Public Properties
  }
}