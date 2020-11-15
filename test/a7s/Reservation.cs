using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Reservation {

[BinaryContent(Name = "Position", NodeType = BinaryContentTypes.Attribute)]
public HexString Position { get; set; }

[BinaryContent(Name = "RectSize", NodeType = BinaryContentTypes.Attribute)]
public HexString RectSize { get; set; }

[BinaryContent(Name = "Direction", NodeType = BinaryContentTypes.Attribute)]
public HexString Direction { get; set; }

}
}
