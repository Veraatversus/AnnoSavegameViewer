namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class LogisticNodeStorageListReservedAmountList {

    [BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Attribute)]
    public object Type { get; set; }

    [BinaryContent(Name = "Index", NodeType = BinaryContentTypes.Attribute)]
    public object Index { get; set; }

    [BinaryContent(Name = "Amount", NodeType = BinaryContentTypes.Attribute)]
    public object Amount { get; set; }

    [BinaryContent(Name = "All", NodeType = BinaryContentTypes.Attribute)]
    public object All { get; set; }

    [BinaryContent(Name = "Parent", NodeType = BinaryContentTypes.Node)]
    public LogisticNodeStorageListReservedAmountListParent Parent { get; set; }
  }
}