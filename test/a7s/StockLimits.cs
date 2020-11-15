using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class StockLimits : KeyValueDictionary<HexString, StockLimitsValue> {

[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
public override List<HexString> Keys { get; set; }

[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
public override List<StockLimitsValue> Values { get; set; }

}
}
