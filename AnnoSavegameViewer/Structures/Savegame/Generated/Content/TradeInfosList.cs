namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class TradeInfosList {

    [BinaryContent(Name = "Amount", NodeType = BinaryContentTypes.Attribute)]
    public object Amount { get; set; }

    [BinaryContent(Name = "TotalPrice", NodeType = BinaryContentTypes.Attribute)]
    public object TotalPrice { get; set; }

  }
}