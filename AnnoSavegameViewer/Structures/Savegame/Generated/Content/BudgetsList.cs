using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class BudgetsList {

    [BinaryContent(Name = "IncomeShare", NodeType = BinaryContentTypes.Attribute)]
    public object IncomeShare { get; set; }

    [BinaryContent(Name = "AvailableMoney", NodeType = BinaryContentTypes.Attribute)]
    public object AvailableMoney { get; set; }

    [BinaryContent(Name = "Costs", NodeType = BinaryContentTypes.Attribute)]
    public object Costs { get; set; }

    [BinaryContent(Name = "Income", NodeType = BinaryContentTypes.Attribute)]
    public object Income { get; set; }

    [BinaryContent(Name = "Limit", NodeType = BinaryContentTypes.Attribute)]
    public object Limit { get; set; }

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public BudgetsListValue Value { get; set; }

  }
}