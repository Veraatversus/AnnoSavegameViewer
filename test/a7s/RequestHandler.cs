using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class RequestHandler {

[BinaryContent(Name = "AllRequests", NodeType = BinaryContentTypes.Node)]
public AllRequests AllRequests { get; set; }

[BinaryContent(Name = "LastTick", NodeType = BinaryContentTypes.Attribute)]
public HexString LastTick { get; set; }

[BinaryContent(Name = "LastConsistencyCheck", NodeType = BinaryContentTypes.Attribute)]
public HexString LastConsistencyCheck { get; set; }

[BinaryContent(Name = "Balance", NodeType = BinaryContentTypes.Node)]
public Balance Balance { get; set; }

}
}
