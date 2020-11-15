using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class WaypointsValue {

[BinaryContent(Name = "TargetObject", NodeType = BinaryContentTypes.Node)]
public TargetObject TargetObject { get; set; }

[BinaryContent(Name = "TravelTime", NodeType = BinaryContentTypes.Attribute)]
public HexString TravelTime { get; set; }

[BinaryContent(Name = "ArrivalTime", NodeType = BinaryContentTypes.Attribute)]
public HexString ArrivalTime { get; set; }

[BinaryContent(Name = "IsHandled", NodeType = BinaryContentTypes.Attribute)]
public HexString IsHandled { get; set; }

[BinaryContent(Name = "Orders", NodeType = BinaryContentTypes.Node)]
public Orders Orders { get; set; }

[BinaryContent(Name = "Owner", NodeType = BinaryContentTypes.Node)]
public WaypointsValuesNoneOwner Owner { get; set; }

}
}
