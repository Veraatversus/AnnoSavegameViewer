using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ThirdParties {

[BinaryContent(Name = "count", NodeType = BinaryContentTypes.Attribute)]
public HexString Count { get; set; }

[BinaryContent(Name = "Profile", NodeType = BinaryContentTypes.Attribute)]
public HexString Profile { get; set; }

[BinaryContent(Name = "Difficulty", NodeType = BinaryContentTypes.Node)]
public ThirdPartiesDifficulty Difficulty { get; set; }

}
}
