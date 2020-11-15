using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ShipNameUsedValue : KeysList<HexString> {

[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
public ShipNameUsedValuesNoneValue Value { get; set; }

[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
public override List<HexString> Keys { get; set; }

}
}
