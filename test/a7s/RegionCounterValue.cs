using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class RegionCounterValue {

[BinaryContent(Name = "Counters", NodeType = BinaryContentTypes.Node)]
public ValuesNoneCounters Counters { get; set; }

}
}
