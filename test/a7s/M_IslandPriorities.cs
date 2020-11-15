using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class M_IslandPriorities : ValuesList<M_IslandPrioritiesValue> {

[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
public override List<M_IslandPrioritiesValue> Values { get; set; }

}
}
