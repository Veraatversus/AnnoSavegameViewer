using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class GameSetupPeers {

[BinaryContent(Name = "count", NodeType = BinaryContentTypes.Attribute)]
public HexString Count { get; set; }

[BinaryContent(Name = "Peer", NodeType = BinaryContentTypes.Node)]
public PeersPeer Peer { get; set; }

}
}
