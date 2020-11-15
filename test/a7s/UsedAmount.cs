using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class UsedAmount : KeyValueDictionary<HexString, UsedAmountValue> {

[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
public override List<UsedAmountValue> Values { get; set; }

[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
public override List<HexString> Keys { get; set; }

}
}
