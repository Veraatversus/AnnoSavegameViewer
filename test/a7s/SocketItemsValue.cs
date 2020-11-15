using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class SocketItemsValue {

[BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
public HexString GUID { get; set; }

[BinaryContent(Name = "ActivationTime", NodeType = BinaryContentTypes.Attribute)]
public HexString ActivationTime { get; set; }

[BinaryContent(Name = "ItemReference", NodeType = BinaryContentTypes.Node)]
public ItemReference ItemReference { get; set; }

}
}
