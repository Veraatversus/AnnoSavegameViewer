using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class HappinessData {

[BinaryContent(Name = "owner", NodeType = BinaryContentTypes.Node)]
public HappinessDataOwner Owner { get; set; }

[BinaryContent(Name = "areaID", NodeType = BinaryContentTypes.Attribute)]
public HexString AreaID { get; set; }

[BinaryContent(Name = "avgHappiness", NodeType = BinaryContentTypes.Attribute)]
public HexString AvgHappiness { get; set; }

[BinaryContent(Name = "pollution", NodeType = BinaryContentTypes.Attribute)]
public HexString Pollution { get; set; }

[BinaryContent(Name = "warfare", NodeType = BinaryContentTypes.Attribute)]
public HexString Warfare { get; set; }

[BinaryContent(Name = "workingConditions", NodeType = BinaryContentTypes.Node)]
public WorkingConditions WorkingConditions { get; set; }

}
}
