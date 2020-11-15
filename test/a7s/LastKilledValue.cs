using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class LastKilledValue {

[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
public LastKilledValuesNoneValue Value { get; set; }

[BinaryContent(Name = "LastAttack", NodeType = BinaryContentTypes.Attribute)]
public HexString LastAttack { get; set; }

[BinaryContent(Name = "SecondLastAttack", NodeType = BinaryContentTypes.Attribute)]
public HexString SecondLastAttack { get; set; }

}
}
