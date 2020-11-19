namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class Budgets {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<BudgetsList> BudgetsList { get; set; }

  }
}