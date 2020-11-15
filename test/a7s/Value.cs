using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Value {

[BinaryContent(Name = "SessionDesc", NodeType = BinaryContentTypes.Node)]
public SessionDesc SessionDesc { get; set; }

[BinaryContent(Name = "SessionData", NodeType = BinaryContentTypes.Node)]
public SessionData SessionData { get; set; }

}
}
