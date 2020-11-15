using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class TransportersValuesNoneValue {

[BinaryContent(Name = "TransporterGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString TransporterGUID { get; set; }

[BinaryContent(Name = "TransporterID", NodeType = BinaryContentTypes.Attribute)]
public HexString TransporterID { get; set; }

[BinaryContent(Name = "Owner", NodeType = BinaryContentTypes.Node)]
public NoneValuesNoneOwner Owner { get; set; }

[BinaryContent(Name = "TransporterType", NodeType = BinaryContentTypes.Attribute)]
public HexString TransporterType { get; set; }

[BinaryContent(Name = "Waypoints", NodeType = BinaryContentTypes.Node)]
public Waypoints Waypoints { get; set; }

[BinaryContent(Name = "NextWaypointPath", NodeType = BinaryContentTypes.Node)]
public NextWaypointPath NextWaypointPath { get; set; }

[BinaryContent(Name = "CurrentTravel", NodeType = BinaryContentTypes.Node)]
public CurrentTravel CurrentTravel { get; set; }

[BinaryContent(Name = "CurrentPosition", NodeType = BinaryContentTypes.Node)]
public CurrentPosition CurrentPosition { get; set; }

[BinaryContent(Name = "CurrentFeedbackPosition", NodeType = BinaryContentTypes.Node)]
public CurrentFeedbackPosition CurrentFeedbackPosition { get; set; }

[BinaryContent(Name = "LoadCapacity", NodeType = BinaryContentTypes.Attribute)]
public HexString LoadCapacity { get; set; }

[BinaryContent(Name = "Load", NodeType = BinaryContentTypes.Node)]
public Load Load { get; set; }

[BinaryContent(Name = "ResetTime", NodeType = BinaryContentTypes.Node)]
public ResetTime ResetTime { get; set; }

}
}
