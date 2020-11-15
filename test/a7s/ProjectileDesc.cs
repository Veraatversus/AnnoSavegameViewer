using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ProjectileDesc {

[BinaryContent(Name = "OwnerID", NodeType = BinaryContentTypes.Attribute)]
public HexString OwnerID { get; set; }

[BinaryContent(Name = "TargetID", NodeType = BinaryContentTypes.Attribute)]
public HexString TargetID { get; set; }

[BinaryContent(Name = "HitType", NodeType = BinaryContentTypes.Node)]
public HitType HitType { get; set; }

[BinaryContent(Name = "AdditionalStatusEffects", NodeType = BinaryContentTypes.Node)]
public AdditionalStatusEffects AdditionalStatusEffects { get; set; }

}
}
