using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ValidTargets : ValuesList<ValidTargetsValue> {

[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
public override List<ValidTargetsValue> Values { get; set; }

}
}
