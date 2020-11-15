using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ReservedSpaceValue {

[BinaryContent(Name = "Parent", NodeType = BinaryContentTypes.Node)]
public Parent Parent { get; set; }

[BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Attribute)]
public HexString Type { get; set; }

[BinaryContent(Name = "Index", NodeType = BinaryContentTypes.Attribute)]
public HexString Index { get; set; }

}
}
