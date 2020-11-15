using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class AttackersValue {

[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
public AttackersValuesNoneValue Value { get; set; }

[BinaryContent(Name = "AmountOfShares", NodeType = BinaryContentTypes.Attribute)]
public HexString AmountOfShares { get; set; }

[BinaryContent(Name = "AmountOfMorale", NodeType = BinaryContentTypes.Attribute)]
public HexString AmountOfMorale { get; set; }

}
}
