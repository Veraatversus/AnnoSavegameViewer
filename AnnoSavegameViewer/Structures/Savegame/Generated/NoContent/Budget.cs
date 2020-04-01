using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Budget {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public BudgetValue Value { get; set; }

  }
}