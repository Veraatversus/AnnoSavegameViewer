using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class NoneCargoGUIDListValue {

[BinaryContent(Name = "CargoGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString CargoGUID { get; set; }

[BinaryContent(Name = "CargoAmount", NodeType = BinaryContentTypes.Attribute)]
public HexString CargoAmount { get; set; }

}
}
