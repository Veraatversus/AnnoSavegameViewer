using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Path {

[BinaryContent(Name = "TangentScale", NodeType = BinaryContentTypes.Attribute)]
public HexString TangentScale { get; set; }

[BinaryContent(Name = "Minimum", NodeType = BinaryContentTypes.Attribute)]
public HexString Minimum { get; set; }

[BinaryContent(Name = "Maximum", NodeType = BinaryContentTypes.Attribute)]
public HexString Maximum { get; set; }

[BinaryContent(Name = "BezierCurve", NodeType = BinaryContentTypes.Node)]
public BezierCurve BezierCurve { get; set; }

}
}
