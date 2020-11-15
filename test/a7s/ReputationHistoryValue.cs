using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ReputationHistoryValue {

[BinaryContent(Name = "TextGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString TextGUID { get; set; }

[BinaryContent(Name = "ReputationChange", NodeType = BinaryContentTypes.Attribute)]
public HexString ReputationChange { get; set; }

}
}
