using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Attacker {

[BinaryContent(Name = "Turrets", NodeType = BinaryContentTypes.Node)]
public Turrets Turrets { get; set; }

[BinaryContent(Name = "AutoAttackID", NodeType = BinaryContentTypes.Attribute)]
public HexString AutoAttackID { get; set; }

[BinaryContent(Name = "FirePerSide", NodeType = BinaryContentTypes.Attribute)]
public HexString FirePerSide { get; set; }

[BinaryContent(Name = "FutureBorrowedShots", NodeType = BinaryContentTypes.Attribute)]
public HexString FutureBorrowedShots { get; set; }

[BinaryContent(Name = "ProjectileLaunchinformation", NodeType = BinaryContentTypes.Node)]
public ProjectileLaunchinformation ProjectileLaunchinformation { get; set; }

[BinaryContent(Name = "IsBlinded", NodeType = BinaryContentTypes.Attribute)]
public HexString IsBlinded { get; set; }

}
}
