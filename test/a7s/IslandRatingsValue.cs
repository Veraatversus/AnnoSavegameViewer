using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class IslandRatingsValue {

[BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
public HexString AreaID { get; set; }

[BinaryContent(Name = "Category", NodeType = BinaryContentTypes.Attribute)]
public HexString Category { get; set; }

[BinaryContent(Name = "Priority", NodeType = BinaryContentTypes.Attribute)]
public HexString Priority { get; set; }

}
}
