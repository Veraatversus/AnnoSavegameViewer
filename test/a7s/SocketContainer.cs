using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class SocketContainer {

[BinaryContent(Name = "SocketItems", NodeType = BinaryContentTypes.Node)]
public SocketItems SocketItems { get; set; }

[BinaryContent(Name = "ExternalSocketBuffs", NodeType = BinaryContentTypes.Node)]
public ExternalSocketBuffs ExternalSocketBuffs { get; set; }

[BinaryContent(Name = "ActivateEquippedItems", NodeType = BinaryContentTypes.Attribute)]
public HexString ActivateEquippedItems { get; set; }

}
}
