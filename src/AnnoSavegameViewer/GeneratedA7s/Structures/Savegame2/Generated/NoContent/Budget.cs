namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class Budget {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public BudgetValue Value { get; set; }

  }
}