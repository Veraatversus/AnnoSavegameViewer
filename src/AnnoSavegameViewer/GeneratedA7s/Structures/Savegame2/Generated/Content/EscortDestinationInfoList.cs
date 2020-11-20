namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class EscortDestinationInfoList {

    #region Public Properties

    [BinaryContent(Name = "PrebuiltObjectSettingsIndex", NodeType = BinaryContentTypes.Attribute)]
    public object PrebuiltObjectSettingsIndex { get; set; }

    [BinaryContent(Name = "EscortMoveDirection", NodeType = BinaryContentTypes.Node)]
    public EscortMoveDirection EscortMoveDirection { get; set; }

    [BinaryContent(Name = "EscortTargetGUID", NodeType = BinaryContentTypes.Node)]
    public EscortTargetGUID EscortTargetGUID { get; set; }

    #endregion Public Properties
  }
}