using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ProductionLayout {

[BinaryContent(Name = "BlockCount", NodeType = BinaryContentTypes.Attribute)]
public HexString BlockCount { get; set; }

[BinaryContent(Name = "Block", NodeType = BinaryContentTypes.Node)]
public ProductionLayoutBlock Block { get; set; }

[BinaryContent(Name = "productionLures", NodeType = BinaryContentTypes.Attribute)]
public HexString ProductionLures { get; set; }

}
}
