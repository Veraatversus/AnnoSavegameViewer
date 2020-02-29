using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MoneyBalanceList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public MoneyBalanceListValue Value { get; set; }

  }
}