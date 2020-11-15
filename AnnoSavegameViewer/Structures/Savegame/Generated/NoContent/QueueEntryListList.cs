namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class QueueEntryListList {

    [BinaryContent(Name = "ShipReference", NodeType = BinaryContentTypes.Node)]
    public ShipReference ShipReference { get; set; }

    [BinaryContent(Name = "QueuePointID", NodeType = BinaryContentTypes.Node)]
    public QueuePointID QueuePointID { get; set; }

    [BinaryContent(Name = "TransportationType", NodeType = BinaryContentTypes.Node)]
    public QueueEntryListListTransportationType TransportationType { get; set; }

  }
}