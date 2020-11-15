using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ConstructionBarSettingsValue {

[BinaryContent(Name = "PinConfigLeft", NodeType = BinaryContentTypes.Node)]
public PinConfigLeft PinConfigLeft { get; set; }

[BinaryContent(Name = "PinConfigRight", NodeType = BinaryContentTypes.Node)]
public PinConfigRight PinConfigRight { get; set; }

}
}
