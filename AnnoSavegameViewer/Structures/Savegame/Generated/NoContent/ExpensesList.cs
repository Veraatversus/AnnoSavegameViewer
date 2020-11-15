namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ExpensesList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ExpensesListValue Value { get; set; }

  }
}