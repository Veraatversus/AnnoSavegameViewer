using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class SessionFilter {

[BinaryContent(Name = "SessionGUIDs", NodeType = BinaryContentTypes.Attribute)]
public HexString SessionGUIDs { get; set; }

}
}
