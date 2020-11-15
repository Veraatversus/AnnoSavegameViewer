using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class View {

[BinaryContent(Name = "From", NodeType = BinaryContentTypes.Attribute)]
public HexString From { get; set; }

[BinaryContent(Name = "At", NodeType = BinaryContentTypes.Attribute)]
public HexString At { get; set; }

[BinaryContent(Name = "Up", NodeType = BinaryContentTypes.Attribute)]
public HexString Up { get; set; }

[BinaryContent(Name = "Direction", NodeType = BinaryContentTypes.Attribute)]
public HexString Direction { get; set; }

}
}
