using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class CurrentMinesValue {

[BinaryContent(Name = "pos", NodeType = BinaryContentTypes.Attribute)]
public HexString Pos { get; set; }

[BinaryContent(Name = "area", NodeType = BinaryContentTypes.Attribute)]
public HexString Area { get; set; }

}
}
