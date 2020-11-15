using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Human {

[BinaryContent(Name = "CompanyName", NodeType = BinaryContentTypes.Attribute)]
public HexString CompanyName { get; set; }

[BinaryContent(Name = "AccountId", NodeType = BinaryContentTypes.Attribute)]
public HexString AccountId { get; set; }

[BinaryContent(Name = "CompanyPortraitGuid", NodeType = BinaryContentTypes.Attribute)]
public HexString CompanyPortraitGuid { get; set; }

[BinaryContent(Name = "CompanyLogoGuid", NodeType = BinaryContentTypes.Attribute)]
public HexString CompanyLogoGuid { get; set; }

[BinaryContent(Name = "AccountUnlocks", NodeType = BinaryContentTypes.Node)]
public AccountUnlocks AccountUnlocks { get; set; }

}
}
