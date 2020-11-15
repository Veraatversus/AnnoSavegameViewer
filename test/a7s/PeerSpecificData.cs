using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class PeerSpecificData {

[BinaryContent(Name = "SessionData", NodeType = BinaryContentTypes.Node)]
public PeerSpecificDataSessionData SessionData { get; set; }

}
}
