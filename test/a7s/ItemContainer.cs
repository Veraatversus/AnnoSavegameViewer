using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ItemContainer {

[BinaryContent(Name = "SlotContainer", NodeType = BinaryContentTypes.Node)]
public SlotContainer SlotContainer { get; set; }

[BinaryContent(Name = "SocketContainer", NodeType = BinaryContentTypes.Node)]
public SocketContainer SocketContainer { get; set; }

[BinaryContent(Name = "KamikazeDecal", NodeType = BinaryContentTypes.Attribute)]
public HexString KamikazeDecal { get; set; }

}
}
