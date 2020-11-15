using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class UniqueShipGuids : KeyValueDictionary<HexString, UniqueShipGuidsValue> {

[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
public override List<UniqueShipGuidsValue> Values { get; set; }

[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
public override List<HexString> Keys { get; set; }

}
}
