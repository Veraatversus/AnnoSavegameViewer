using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class BezierCurve : ValuesList<BezierCurveValue> {

[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
public override List<BezierCurveValue> Values { get; set; }

}
}
