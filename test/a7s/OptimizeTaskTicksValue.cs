using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class OptimizeTaskTicksValue {

[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
public OptimizeTaskTicksValuesNoneValue Value { get; set; }

[BinaryContent(Name = "LastTrigger", NodeType = BinaryContentTypes.Attribute)]
public HexString LastTrigger { get; set; }

[BinaryContent(Name = "BuildCount", NodeType = BinaryContentTypes.Attribute)]
public HexString BuildCount { get; set; }

}
}
