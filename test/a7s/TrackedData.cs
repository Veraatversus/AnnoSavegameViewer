using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class TrackedData : KeysList<HexString> {

[BinaryContent(Name = "LowTracked", NodeType = BinaryContentTypes.Attribute)]
public HexString LowTracked { get; set; }

[BinaryContent(Name = "HighTracked", NodeType = BinaryContentTypes.Attribute)]
public HexString HighTracked { get; set; }

[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
public override List<HexString> Keys { get; set; }

}
}
