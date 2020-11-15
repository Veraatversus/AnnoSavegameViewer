using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Projectile {

[BinaryContent(Name = "ProjectileDesc", NodeType = BinaryContentTypes.Node)]
public ProjectileDesc ProjectileDesc { get; set; }

[BinaryContent(Name = "LaunchRotationWS", NodeType = BinaryContentTypes.Attribute)]
public HexString LaunchRotationWS { get; set; }

[BinaryContent(Name = "ProjectileState", NodeType = BinaryContentTypes.Attribute)]
public HexString ProjectileState { get; set; }

[BinaryContent(Name = "HitTimeout", NodeType = BinaryContentTypes.Attribute)]
public HexString HitTimeout { get; set; }

[BinaryContent(Name = "Velocity", NodeType = BinaryContentTypes.Attribute)]
public HexString Velocity { get; set; }

[BinaryContent(Name = "LaunchTime", NodeType = BinaryContentTypes.Attribute)]
public HexString LaunchTime { get; set; }

}
}
