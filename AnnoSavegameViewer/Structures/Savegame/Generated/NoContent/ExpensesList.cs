using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ExpensesList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ExpensesListValue Value { get; set; }

  }
}