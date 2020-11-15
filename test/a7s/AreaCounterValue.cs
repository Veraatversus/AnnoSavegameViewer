using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class AreaCounterValue {

[BinaryContent(Name = "Counters", NodeType = BinaryContentTypes.Node)]
public NoneCounters Counters { get; set; }

}
}
