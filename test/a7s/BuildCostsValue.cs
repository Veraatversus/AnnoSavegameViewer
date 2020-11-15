using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class BuildCostsValue {

[BinaryContent(Name = "ProductGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString ProductGUID { get; set; }

[BinaryContent(Name = "Amount", NodeType = BinaryContentTypes.Attribute)]
public HexString Amount { get; set; }

}
}
