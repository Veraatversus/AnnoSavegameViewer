using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class BuildingsByGUIDValue : KeysList<HexString> {

[BinaryContent(Name = "size", NodeType = BinaryContentTypes.Attribute)]
public HexString Size { get; set; }

[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
public override List<HexString> Keys { get; set; }

}
}
