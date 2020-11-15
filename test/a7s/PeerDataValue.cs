using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class PeerDataValue {

[BinaryContent(Name = "CompanyLevel", NodeType = BinaryContentTypes.Attribute)]
public HexString CompanyLevel { get; set; }

[BinaryContent(Name = "PeerSettings", NodeType = BinaryContentTypes.Node)]
public PeerSettings PeerSettings { get; set; }

}
}
