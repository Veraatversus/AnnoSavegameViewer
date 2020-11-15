using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class SettleHandler {

[BinaryContent(Name = "LastSettleTime", NodeType = BinaryContentTypes.Attribute)]
public HexString LastSettleTime { get; set; }

[BinaryContent(Name = "NextSettleMissionID", NodeType = BinaryContentTypes.Attribute)]
public HexString NextSettleMissionID { get; set; }

[BinaryContent(Name = "SettleMission", NodeType = BinaryContentTypes.Node)]
public SettleMission SettleMission { get; set; }

}
}
