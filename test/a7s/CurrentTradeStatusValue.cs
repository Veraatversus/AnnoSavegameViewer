using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class CurrentTradeStatusValue : ValuesList<MetaInteractionCurrentTradeStatusValuesNoneValue> {

[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
public CurrentTradeStatusValuesNoneValue Value { get; set; }

[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
public override List<MetaInteractionCurrentTradeStatusValuesNoneValue> Values { get; set; }

}
}
