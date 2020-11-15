using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class CharterRouteDescription {

[BinaryContent(Name = "SourceArea", NodeType = BinaryContentTypes.Attribute)]
public HexString SourceArea { get; set; }

[BinaryContent(Name = "TargetArea", NodeType = BinaryContentTypes.Attribute)]
public HexString TargetArea { get; set; }

}
}
