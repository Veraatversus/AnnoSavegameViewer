namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class DistributionPausedInfoList {

    #region Public Properties

    [BinaryContent(Name = "DistributionPaused", NodeType = BinaryContentTypes.Attribute)]
    public object DistributionPaused { get; set; }

    [BinaryContent(Name = "CurrentlyProvided", NodeType = BinaryContentTypes.Attribute)]
    public object CurrentlyProvided { get; set; }

    #endregion Public Properties
  }
}