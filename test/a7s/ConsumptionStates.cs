using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ConsumptionStates : KeyValueDictionary<HexString, ConsumptionStatesValue> {

[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
public override List<HexString> Keys { get; set; }

[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
public override List<ConsumptionStatesValue> Values { get; set; }

}
}
