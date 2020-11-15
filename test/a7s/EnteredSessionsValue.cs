using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class EnteredSessionsValue {

[BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
public HexString GUID { get; set; }

[BinaryContent(Name = "Roles", NodeType = BinaryContentTypes.Attribute)]
public HexString Roles { get; set; }

[BinaryContent(Name = "Time", NodeType = BinaryContentTypes.Attribute)]
public HexString Time { get; set; }

}
}
