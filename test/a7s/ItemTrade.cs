using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ItemTrade {

[BinaryContent(Name = "Items", NodeType = BinaryContentTypes.Node)]
public Items Items { get; set; }

[BinaryContent(Name = "LastReroll", NodeType = BinaryContentTypes.Attribute)]
public HexString LastReroll { get; set; }

}
}
