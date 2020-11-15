using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class PlannedLoadValue {

[BinaryContent(Name = "UnloadGuid", NodeType = BinaryContentTypes.Attribute)]
public HexString UnloadGuid { get; set; }

[BinaryContent(Name = "UnloadAmount", NodeType = BinaryContentTypes.Attribute)]
public HexString UnloadAmount { get; set; }

[BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
public HexString ID { get; set; }

[BinaryContent(Name = "LoadGuid", NodeType = BinaryContentTypes.Attribute)]
public HexString LoadGuid { get; set; }

}
}
