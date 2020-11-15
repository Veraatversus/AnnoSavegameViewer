using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class DivingBellObjectInfoListValue {

[BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
public HexString GUID { get; set; }

[BinaryContent(Name = "CargoGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString CargoGUID { get; set; }

[BinaryContent(Name = "IsTreasure", NodeType = BinaryContentTypes.Attribute)]
public HexString IsTreasure { get; set; }

}
}
