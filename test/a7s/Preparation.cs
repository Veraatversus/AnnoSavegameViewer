using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Preparation {

[BinaryContent(Name = "kontorID", NodeType = BinaryContentTypes.Attribute)]
public HexString KontorID { get; set; }

[BinaryContent(Name = "TradeRequests", NodeType = BinaryContentTypes.Node)]
public TradeRequests TradeRequests { get; set; }

[BinaryContent(Name = "ReservedAmount", NodeType = BinaryContentTypes.Node)]
public PreparationReservedAmount ReservedAmount { get; set; }

}
}
