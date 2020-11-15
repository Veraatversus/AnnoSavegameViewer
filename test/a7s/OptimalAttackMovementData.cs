using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class OptimalAttackMovementData {

[BinaryContent(Name = "OptimalAngleWS", NodeType = BinaryContentTypes.Attribute)]
public HexString OptimalAngleWS { get; set; }

[BinaryContent(Name = "OptimalDistanceWS", NodeType = BinaryContentTypes.Attribute)]
public HexString OptimalDistanceWS { get; set; }

}
}
