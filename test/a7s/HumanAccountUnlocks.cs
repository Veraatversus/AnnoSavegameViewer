using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class HumanAccountUnlocks {

[BinaryContent(Name = "count", NodeType = BinaryContentTypes.Attribute)]
public HexString Count { get; set; }

[BinaryContent(Name = "Asset", NodeType = BinaryContentTypes.Attribute)]
public HexString Asset { get; set; }

}
}
