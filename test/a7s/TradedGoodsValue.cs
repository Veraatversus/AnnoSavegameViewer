using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class TradedGoodsValue {

[BinaryContent(Name = "GoodGuid", NodeType = BinaryContentTypes.Attribute)]
public HexString GoodGuid { get; set; }

[BinaryContent(Name = "GoodAmount", NodeType = BinaryContentTypes.Attribute)]
public HexString GoodAmount { get; set; }

}
}
