using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class VisitedHarbors : ValuesList<VisitedHarborsValue> {

[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
public override List<VisitedHarborsValue> Values { get; set; }

}
}
