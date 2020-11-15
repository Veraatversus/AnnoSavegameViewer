namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class LastKilledList {

    #region Public Properties

    [BinaryContent(Name = "LastAttack", NodeType = BinaryContentTypes.Attribute)]
    public object LastAttack { get; set; }

    [BinaryContent(Name = "SecondLastAttack", NodeType = BinaryContentTypes.Attribute)]
    public object SecondLastAttack { get; set; }

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public LastKilledListValue Value { get; set; }

    #endregion Public Properties
  }
}