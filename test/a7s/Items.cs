using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Items : ValuesList<ItemsValue> {

[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
public override List<ItemsValue> Values { get; set; }

}
}
