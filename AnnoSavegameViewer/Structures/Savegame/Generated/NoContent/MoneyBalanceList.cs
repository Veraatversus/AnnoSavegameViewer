using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MoneyBalanceList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public MoneyBalanceListValue Value { get; set; }

  }
}