using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class MetaInteractionCurrentTradeStatusValuesNoneValue {

[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
public CurrentTradeStatusValuesNoneValuesNoneValue Value { get; set; }

[BinaryContent(Name = "Step", NodeType = BinaryContentTypes.Attribute)]
public HexString Step { get; set; }

[BinaryContent(Name = "CurrentAmount", NodeType = BinaryContentTypes.Attribute)]
public HexString CurrentAmount { get; set; }

}
}
