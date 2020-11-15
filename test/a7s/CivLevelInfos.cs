using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class CivLevelInfos : ValuesList<CivLevelInfosValue> {

[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
public override List<CivLevelInfosValue> Values { get; set; }

}
}
