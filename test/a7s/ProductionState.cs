using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ProductionState {

[BinaryContent(Name = "InProgress", NodeType = BinaryContentTypes.Attribute)]
public HexString InProgress { get; set; }

[BinaryContent(Name = "RemainingTime", NodeType = BinaryContentTypes.Attribute)]
public HexString RemainingTime { get; set; }

[BinaryContent(Name = "Productivity", NodeType = BinaryContentTypes.Attribute)]
public HexString Productivity { get; set; }

}
}
