using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MetaResourceHandler {

    [BinaryContent(Name = "LastBudgetTick", NodeType = BinaryContentTypes.Attribute)]
    public object LastBudgetTick { get; set; }

    [BinaryContent(Name = "CheatedMoney", NodeType = BinaryContentTypes.Attribute)]
    public object CheatedMoney { get; set; }

    [BinaryContent(Name = "CheatedBalance", NodeType = BinaryContentTypes.Attribute)]
    public object CheatedBalance { get; set; }

    [BinaryContent(Name = "SessionMoneyBalance", NodeType = BinaryContentTypes.Node)]
    public SessionMoneyBalance SessionMoneyBalance { get; set; }

    [BinaryContent(Name = "BalanceBeforeBudgets", NodeType = BinaryContentTypes.Node)]
    public BalanceBeforeBudgets BalanceBeforeBudgets { get; set; }

    [BinaryContent(Name = "Budgets", NodeType = BinaryContentTypes.Node)]
    public Budgets Budgets { get; set; }

  }
}