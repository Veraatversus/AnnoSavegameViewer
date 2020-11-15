using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Fertility : KeysList<DescriptionInt> {

[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
public override List<DescriptionInt> Keys { get; set; }

}
}
