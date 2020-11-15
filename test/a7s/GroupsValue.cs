using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class GroupsValue {

[BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
public HexString ID { get; set; }

[BinaryContent(Name = "Units", NodeType = BinaryContentTypes.Attribute)]
public HexString Units { get; set; }

}
}
