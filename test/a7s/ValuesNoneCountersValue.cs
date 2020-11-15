using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ValuesNoneCountersValue : ValuesList<ValuesNoneCountersValuesNoneValue> {

[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
public override List<ValuesNoneCountersValuesNoneValue> Values { get; set; }

}
}
