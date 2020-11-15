using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class LogisticNodeStorageValue {

[BinaryContent(Name = "ProductGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString ProductGUID { get; set; }

[BinaryContent(Name = "CurrentAmount", NodeType = BinaryContentTypes.Attribute)]
public HexString CurrentAmount { get; set; }

[BinaryContent(Name = "MaxAmount", NodeType = BinaryContentTypes.Attribute)]
public HexString MaxAmount { get; set; }

[BinaryContent(Name = "ReservedAmount", NodeType = BinaryContentTypes.Node)]
public ValuesNoneReservedAmount ReservedAmount { get; set; }

[BinaryContent(Name = "ReservedSpace", NodeType = BinaryContentTypes.Node)]
public ValuesNoneReservedSpace ReservedSpace { get; set; }

}
}
