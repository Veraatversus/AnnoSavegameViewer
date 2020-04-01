using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class QueueEntryListList {

    [BinaryContent(Name = "ShipReference", NodeType = BinaryContentTypes.Node)]
    public ShipReference ShipReference { get; set; }

    [BinaryContent(Name = "QueuePointID", NodeType = BinaryContentTypes.Node)]
    public QueuePointID QueuePointID { get; set; }

    [BinaryContent(Name = "TransportationType", NodeType = BinaryContentTypes.Node)]
    public QueueEntryListListTransportationType TransportationType { get; set; }

  }
}