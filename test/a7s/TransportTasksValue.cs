using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class TransportTasksValue {

[BinaryContent(Name = "From", NodeType = BinaryContentTypes.Attribute)]
public HexString From { get; set; }

[BinaryContent(Name = "To", NodeType = BinaryContentTypes.Attribute)]
public HexString To { get; set; }

[BinaryContent(Name = "Product", NodeType = BinaryContentTypes.Attribute)]
public HexString Product { get; set; }

[BinaryContent(Name = "Balance", NodeType = BinaryContentTypes.Attribute)]
public HexString Balance { get; set; }

[BinaryContent(Name = "TransportType", NodeType = BinaryContentTypes.Node)]
public NoneTransportType TransportType { get; set; }

}
}
