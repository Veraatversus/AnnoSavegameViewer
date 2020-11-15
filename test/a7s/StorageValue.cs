using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class StorageValue {

[BinaryContent(Name = "ProductGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString ProductGUID { get; set; }

[BinaryContent(Name = "CurrentAmount", NodeType = BinaryContentTypes.Attribute)]
public HexString CurrentAmount { get; set; }

[BinaryContent(Name = "MaxAmount", NodeType = BinaryContentTypes.Attribute)]
public HexString MaxAmount { get; set; }

[BinaryContent(Name = "ReservedAmount", NodeType = BinaryContentTypes.Node)]
public ReservedAmount ReservedAmount { get; set; }

[BinaryContent(Name = "ReservedSpace", NodeType = BinaryContentTypes.Node)]
public ReservedSpace ReservedSpace { get; set; }

[BinaryContent(Name = "CanBeNegative", NodeType = BinaryContentTypes.Attribute)]
public HexString CanBeNegative { get; set; }

}
}
