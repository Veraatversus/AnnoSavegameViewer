using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class CurrentTravelValue {

[BinaryContent(Name = "Target", NodeType = BinaryContentTypes.Attribute)]
public HexString Target { get; set; }

[BinaryContent(Name = "Origin", NodeType = BinaryContentTypes.Attribute)]
public HexString Origin { get; set; }

}
}
