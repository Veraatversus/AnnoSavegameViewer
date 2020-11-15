namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class AttackersList {

    [BinaryContent(Name = "AmountOfShares", NodeType = BinaryContentTypes.Attribute)]
    public object AmountOfShares { get; set; }

    [BinaryContent(Name = "AmountOfMorale", NodeType = BinaryContentTypes.Attribute)]
    public object AmountOfMorale { get; set; }

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public AttackersListValue Value { get; set; }
  }
}