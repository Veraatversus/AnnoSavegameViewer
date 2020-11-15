using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class LastResult {

[BinaryContent(Name = "LastResult", NodeType = BinaryContentTypes.Node)]
public LastResultLastResult LastResultItem { get; set; }

[BinaryContent(Name = "Defender", NodeType = BinaryContentTypes.Node)]
public Defender Defender { get; set; }

[BinaryContent(Name = "Attackers", NodeType = BinaryContentTypes.Node)]
public Attackers Attackers { get; set; }

[BinaryContent(Name = "OriginalShareOwner", NodeType = BinaryContentTypes.Node)]
public OriginalShareOwner OriginalShareOwner { get; set; }

[BinaryContent(Name = "MoraleLeft", NodeType = BinaryContentTypes.Attribute)]
public HexString MoraleLeft { get; set; }

}
}
