using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class CoastLinePointsValue {

[BinaryContent(Name = "pos", NodeType = BinaryContentTypes.Attribute)]
public HexString Pos { get; set; }

[BinaryContent(Name = "dir", NodeType = BinaryContentTypes.Attribute)]
public HexString Dir { get; set; }

}
}
