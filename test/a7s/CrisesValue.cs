using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class CrisesValue {

[BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Node)]
public ValuesNoneType Type { get; set; }

[BinaryContent(Name = "Area", NodeType = BinaryContentTypes.Attribute)]
public HexString Area { get; set; }

[BinaryContent(Name = "Creation", NodeType = BinaryContentTypes.Attribute)]
public HexString Creation { get; set; }

[BinaryContent(Name = "Product", NodeType = BinaryContentTypes.Attribute)]
public HexString Product { get; set; }

}
}
