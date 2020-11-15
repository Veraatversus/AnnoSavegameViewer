using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class PassiveTradeEntriesValue : ValuesList<HistoryPassiveTradeEntriesValuesNoneValue> {

[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
public PassiveTradeEntriesValuesNoneValue Value { get; set; }

[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
public override List<HistoryPassiveTradeEntriesValuesNoneValue> Values { get; set; }

}
}
