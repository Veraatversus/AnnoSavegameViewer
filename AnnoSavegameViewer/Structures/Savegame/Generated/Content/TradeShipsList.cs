using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class TradeShipsList {

    [BinaryContent(Name = "ObjID", NodeType = BinaryContentTypes.Attribute)]
    public object ObjID { get; set; }

    [BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
    public object ID { get; set; }

    [BinaryContent(Name = "OnRoute", NodeType = BinaryContentTypes.Attribute)]
    public object OnRoute { get; set; }

    [BinaryContent(Name = "SlotCount", NodeType = BinaryContentTypes.Attribute)]
    public object SlotCount { get; set; }

    [BinaryContent(Name = "StackSize", NodeType = BinaryContentTypes.Attribute)]
    public object StackSize { get; set; }

    [BinaryContent(Name = "Speed", NodeType = BinaryContentTypes.Attribute)]
    public object Speed { get; set; }

    [BinaryContent(Name = "TransportType", NodeType = BinaryContentTypes.Node)]
    public TransportType TransportType { get; set; }

  }
}