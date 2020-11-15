using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Sellable {

[BinaryContent(Name = "allowedBuyers", NodeType = BinaryContentTypes.Attribute)]
public HexString AllowedBuyers { get; set; }

}
}
