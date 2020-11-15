using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class QueueEntryListValue {

[BinaryContent(Name = "ShipReference", NodeType = BinaryContentTypes.Node)]
public ShipReference ShipReference { get; set; }

[BinaryContent(Name = "QueuePointID", NodeType = BinaryContentTypes.Node)]
public QueuePointID QueuePointID { get; set; }

[BinaryContent(Name = "TransportationType", NodeType = BinaryContentTypes.Node)]
public NoneTransportationType TransportationType { get; set; }

}
}
