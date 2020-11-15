using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class SavegameHistoryValue {

[BinaryContent(Name = "Timestamp", NodeType = BinaryContentTypes.Attribute)]
public HexString Timestamp { get; set; }

[BinaryContent(Name = "Changelist", NodeType = BinaryContentTypes.Attribute)]
public HexString Changelist { get; set; }

[BinaryContent(Name = "RequiredUnlocks", NodeType = BinaryContentTypes.Node)]
public RequiredUnlocks RequiredUnlocks { get; set; }

}
}
