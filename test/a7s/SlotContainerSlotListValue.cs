using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class SlotContainerSlotListValue {

[BinaryContent(Name = "Stack", NodeType = BinaryContentTypes.Node)]
public NoneStack Stack { get; set; }

[BinaryContent(Name = "ProductStackSize", NodeType = BinaryContentTypes.Attribute)]
public HexString ProductStackSize { get; set; }

}
}
