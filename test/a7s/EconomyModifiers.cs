using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class EconomyModifiers : KeyValueDictionary<DescriptionInt, EconomyModifiersValue> {

[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
public override List<DescriptionInt> Keys { get; set; }

[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
public override List<EconomyModifiersValue> Values { get; set; }

}
}
