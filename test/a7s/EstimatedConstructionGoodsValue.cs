using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class EstimatedConstructionGoodsValue {

[BinaryContent(Name = "Product", NodeType = BinaryContentTypes.Attribute)]
public HexString Product { get; set; }

[BinaryContent(Name = "Count", NodeType = BinaryContentTypes.Attribute)]
public HexString Count { get; set; }

}
}
