using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Turrets {

[BinaryContent(Name = "count", NodeType = BinaryContentTypes.Attribute)]
public HexString Count { get; set; }

[BinaryContent(Name = "CanFireAtTarget", NodeType = BinaryContentTypes.Attribute)]
public HexString CanFireAtTarget { get; set; }

}
}
