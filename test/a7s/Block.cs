using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Block {

[BinaryContent(Name = "mode", NodeType = BinaryContentTypes.Attribute)]
public HexString Mode { get; set; }

[BinaryContent(Name = "x", NodeType = BinaryContentTypes.Attribute)]
public HexString X { get; set; }

[BinaryContent(Name = "y", NodeType = BinaryContentTypes.Attribute)]
public HexString Y { get; set; }

[BinaryContent(Name = "default", NodeType = BinaryContentTypes.Node)]
public Default Default { get; set; }

[BinaryContent(Name = "values", NodeType = BinaryContentTypes.Node)]
public BlockValues Values { get; set; }

}
}
