using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class GoodInfosValue {

[BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
public HexString ID { get; set; }

[BinaryContent(Name = "StationID", NodeType = BinaryContentTypes.Attribute)]
public HexString StationID { get; set; }

[BinaryContent(Name = "ProductGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString ProductGUID { get; set; }

[BinaryContent(Name = "Amount", NodeType = BinaryContentTypes.Attribute)]
public HexString Amount { get; set; }

[BinaryContent(Name = "Index", NodeType = BinaryContentTypes.Attribute)]
public HexString Index { get; set; }

[BinaryContent(Name = "IsLoading", NodeType = BinaryContentTypes.Attribute)]
public HexString IsLoading { get; set; }

}
}
