using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class TextInfoValue {

[BinaryContent(Name = "type", NodeType = BinaryContentTypes.Attribute)]
public HexString Type { get; set; }

[BinaryContent(Name = "valArea", NodeType = BinaryContentTypes.Attribute)]
public HexString ValArea { get; set; }

}
}
