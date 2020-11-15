using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class BezierCurveValue {

[BinaryContent(Name = "p", NodeType = BinaryContentTypes.Attribute)]
public HexString P { get; set; }

[BinaryContent(Name = "i", NodeType = BinaryContentTypes.Attribute)]
public HexString I { get; set; }

[BinaryContent(Name = "o", NodeType = BinaryContentTypes.Attribute)]
public HexString O { get; set; }

}
}
