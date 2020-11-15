using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class AreaManagers : ValuesList<AreaManager> {

[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
public override List<AreaManager> Values { get; set; }

}
}
