using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class EconomyModifiersValue : KeyValueDictionary<Int32, EconomyModifiersValuesNoneValue> {

[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
public override List<EconomyModifiersValuesNoneValue> Values { get; set; }

[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
public override List<Int32> Keys { get; set; }

}
}
