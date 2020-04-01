using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class BalanceBeforeBudgets {

    [BinaryContent(Name = "Income", NodeType = BinaryContentTypes.Attribute)]
    public object Income { get; set; }

    [BinaryContent(Name = "Expenses", NodeType = BinaryContentTypes.Attribute)]
    public object Expenses { get; set; }

  }
}