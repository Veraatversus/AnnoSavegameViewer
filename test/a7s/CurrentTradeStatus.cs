using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class CurrentTradeStatus : ValuesList<CurrentTradeStatusValue> {

[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
public override List<CurrentTradeStatusValue> Values { get; set; }

}
}
