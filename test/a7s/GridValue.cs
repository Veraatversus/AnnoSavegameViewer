using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class GridValue {

[BinaryContent(Name = "FreeTiles", NodeType = BinaryContentTypes.Attribute)]
public HexString FreeTiles { get; set; }

[BinaryContent(Name = "DistanceToBlocker", NodeType = BinaryContentTypes.Attribute)]
public HexString DistanceToBlocker { get; set; }

}
}
