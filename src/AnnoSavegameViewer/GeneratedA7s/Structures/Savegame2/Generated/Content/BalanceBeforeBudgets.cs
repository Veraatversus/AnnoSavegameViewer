namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class BalanceBeforeBudgets {

    #region Public Properties

    [BinaryContent(Name = "Income", NodeType = BinaryContentTypes.Attribute)]
    public object Income { get; set; }

    [BinaryContent(Name = "Expenses", NodeType = BinaryContentTypes.Attribute)]
    public object Expenses { get; set; }

    #endregion Public Properties
  }
}