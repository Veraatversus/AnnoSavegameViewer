using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class InfectionChanceTrackerValuesNoneValue {

[BinaryContent(Name = "Counter", NodeType = BinaryContentTypes.Attribute)]
public HexString Counter { get; set; }

[BinaryContent(Name = "AccumulatedInfectionChance", NodeType = BinaryContentTypes.Attribute)]
public HexString AccumulatedInfectionChance { get; set; }

[BinaryContent(Name = "HealingUnitSent", NodeType = BinaryContentTypes.Attribute)]
public HexString HealingUnitSent { get; set; }

}
}
