using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class PeerSpecificDataSessionData : ValuesList<SessionDataValue> {

[BinaryContent(Name = "size", NodeType = BinaryContentTypes.Attribute)]
public HexString Size { get; set; }

[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
public override List<SessionDataValue> Values { get; set; }

}
}
