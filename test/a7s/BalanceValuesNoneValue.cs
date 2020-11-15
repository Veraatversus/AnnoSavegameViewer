using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class BalanceValuesNoneValue {

[BinaryContent(Name = "NetBalance", NodeType = BinaryContentTypes.Attribute)]
public HexString NetBalance { get; set; }

[BinaryContent(Name = "ProvidedFor", NodeType = BinaryContentTypes.Node)]
public ProvidedFor ProvidedFor { get; set; }

[BinaryContent(Name = "ProvidedBy", NodeType = BinaryContentTypes.Node)]
public ProvidedBy ProvidedBy { get; set; }

}
}
