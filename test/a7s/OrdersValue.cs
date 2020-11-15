using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class OrdersValue {

[BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Attribute)]
public HexString Type { get; set; }

[BinaryContent(Name = "ProductGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString ProductGUID { get; set; }

[BinaryContent(Name = "ProductAmount", NodeType = BinaryContentTypes.Attribute)]
public HexString ProductAmount { get; set; }

}
}
