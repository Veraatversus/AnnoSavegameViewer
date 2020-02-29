using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SessionMoneyBalanceList {

    [BinaryContent(Name = "Income", NodeType = BinaryContentTypes.Attribute)]
    public object Income { get; set; }

    [BinaryContent(Name = "Expenses", NodeType = BinaryContentTypes.Node)]
    public Expenses Expenses { get; set; }

  }
}