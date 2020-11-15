using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class MetaResourceHandler {

[BinaryContent(Name = "SessionMoneyBalance", NodeType = BinaryContentTypes.Node)]
public SessionMoneyBalance SessionMoneyBalance { get; set; }

[BinaryContent(Name = "BalanceBeforeBudgets", NodeType = BinaryContentTypes.Node)]
public BalanceBeforeBudgets BalanceBeforeBudgets { get; set; }

[BinaryContent(Name = "Budgets", NodeType = BinaryContentTypes.Node)]
public Budgets Budgets { get; set; }

[BinaryContent(Name = "LastBudgetTick", NodeType = BinaryContentTypes.Attribute)]
public HexString LastBudgetTick { get; set; }

[BinaryContent(Name = "CheatedMoney", NodeType = BinaryContentTypes.Attribute)]
public HexString CheatedMoney { get; set; }

[BinaryContent(Name = "CheatedBalance", NodeType = BinaryContentTypes.Attribute)]
public HexString CheatedBalance { get; set; }

}
}
