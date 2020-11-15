using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class AreaInfo : KeyValueDictionary<Int16, AreaInfoValue> {

[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
public override List<Int16> Keys { get; set; }

[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
public override List<AreaInfoValue> Values { get; set; }

}
}
