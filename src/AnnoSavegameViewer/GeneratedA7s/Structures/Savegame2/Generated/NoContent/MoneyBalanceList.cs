namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class MoneyBalanceList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public MoneyBalanceListValue Value { get; set; }

  }
}