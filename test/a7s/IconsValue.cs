using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class IconsValue {

[BinaryContent(Name = "VisibilityMaskNew", NodeType = BinaryContentTypes.Attribute)]
public HexString VisibilityMaskNew { get; set; }

[BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
public HexString GUID { get; set; }

[BinaryContent(Name = "ShowTime", NodeType = BinaryContentTypes.Attribute)]
public HexString ShowTime { get; set; }

[BinaryContent(Name = "HadCallback", NodeType = BinaryContentTypes.Attribute)]
public HexString HadCallback { get; set; }

}
}
