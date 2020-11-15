namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class Preparation {

    [BinaryContent(Name = "kontorID", NodeType = BinaryContentTypes.Attribute)]
    public object KontorID { get; set; }

    [BinaryContent(Name = "TradeRequests", NodeType = BinaryContentTypes.Node)]
    public TradeRequests TradeRequests { get; set; }

    [BinaryContent(Name = "ReservedAmount", NodeType = BinaryContentTypes.Node)]
    public ReservedAmount ReservedAmount { get; set; }

  }
}