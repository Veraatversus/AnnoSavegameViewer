using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ItemsValue {

[BinaryContent(Name = "Amount", NodeType = BinaryContentTypes.Attribute)]
public HexString Amount { get; set; }

[BinaryContent(Name = "AssetGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString AssetGUID { get; set; }

}
}
