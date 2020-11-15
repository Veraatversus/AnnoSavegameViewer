using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class MessageStatesValue {

[BinaryContent(Name = "ForbidBefore", NodeType = BinaryContentTypes.Attribute)]
public HexString ForbidBefore { get; set; }

[BinaryContent(Name = "Executed", NodeType = BinaryContentTypes.Attribute)]
public HexString Executed { get; set; }

[BinaryContent(Name = "TriggerCounts", NodeType = BinaryContentTypes.Attribute)]
public HexString TriggerCounts { get; set; }

}
}
