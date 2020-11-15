using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class SessionCounterValuesNoneCountersValuesNoneValue {

[BinaryContent(Name = "PlayerCounter", NodeType = BinaryContentTypes.Node)]
public CountersValuesNoneValuesNonePlayerCounter PlayerCounter { get; set; }

[BinaryContent(Name = "Context", NodeType = BinaryContentTypes.Attribute)]
public HexString Context { get; set; }

[BinaryContent(Name = "Value", NodeType = BinaryContentTypes.Attribute)]
public HexString Value { get; set; }

}
}
