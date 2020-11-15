using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class SessionRandomManager {

[BinaryContent(Name = "NetworkSafeRandom", NodeType = BinaryContentTypes.Node)]
public SessionRandomManagerNetworkSafeRandom NetworkSafeRandom { get; set; }

}
}
