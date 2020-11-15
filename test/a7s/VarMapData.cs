using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class VarMapData {

[BinaryContent(Name = "SparseEnabled", NodeType = BinaryContentTypes.Attribute)]
public HexString SparseEnabled { get; set; }

[BinaryContent(Name = "x", NodeType = BinaryContentTypes.Attribute)]
public HexString X { get; set; }

[BinaryContent(Name = "y", NodeType = BinaryContentTypes.Attribute)]
public HexString Y { get; set; }

[BinaryContent(Name = "block", NodeType = BinaryContentTypes.Node)]
public Block Block { get; set; }

}
}
