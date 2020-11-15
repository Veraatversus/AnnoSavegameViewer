using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class GroupHandler {

[BinaryContent(Name = "NextGroupID", NodeType = BinaryContentTypes.Attribute)]
public HexString NextGroupID { get; set; }

[BinaryContent(Name = "Groups", NodeType = BinaryContentTypes.Node)]
public Groups Groups { get; set; }

}
}
