using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class LoadValue {

[BinaryContent(Name = "ProductGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString ProductGUID { get; set; }

[BinaryContent(Name = "ProductAmount", NodeType = BinaryContentTypes.Attribute)]
public HexString ProductAmount { get; set; }

}
}
