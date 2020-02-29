using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AttackersList {

    #region Public Properties

    [BinaryContent(Name = "AmountOfMorale", NodeType = BinaryContentTypes.Attribute)]
    public object AmountOfMorale { get; set; }

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public AttackersListValue Value { get; set; }

    #endregion Public Properties
  }
}