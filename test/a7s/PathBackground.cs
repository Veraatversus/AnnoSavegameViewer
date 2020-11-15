using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class PathBackground {

[BinaryContent(Name = "CurrentPath", NodeType = BinaryContentTypes.Attribute)]
public HexString CurrentPath { get; set; }

}
}
