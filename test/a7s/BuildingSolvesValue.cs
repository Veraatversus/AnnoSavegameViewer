using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class BuildingSolvesValue {

[BinaryContent(Name = "Guid", NodeType = BinaryContentTypes.Attribute)]
public HexString Guid { get; set; }

[BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
public HexString AreaID { get; set; }

[BinaryContent(Name = "Timestamp", NodeType = BinaryContentTypes.Attribute)]
public HexString Timestamp { get; set; }

[BinaryContent(Name = "SessionGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString SessionGUID { get; set; }

}
}
