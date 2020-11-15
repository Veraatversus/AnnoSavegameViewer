using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class RequirementsValue {

[BinaryContent(Name = "Region", NodeType = BinaryContentTypes.Node)]
public NoneRegion Region { get; set; }

[BinaryContent(Name = "CivLevel", NodeType = BinaryContentTypes.Node)]
public CivLevel CivLevel { get; set; }

[BinaryContent(Name = "Amount", NodeType = BinaryContentTypes.Attribute)]
public HexString Amount { get; set; }

}
}
