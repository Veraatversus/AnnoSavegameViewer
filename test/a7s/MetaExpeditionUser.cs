using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class MetaExpeditionUser {

[BinaryContent(Name = "expeditions", NodeType = BinaryContentTypes.Node)]
public Expeditions Expeditions { get; set; }

[BinaryContent(Name = "expeditionSlots", NodeType = BinaryContentTypes.Node)]
public ExpeditionSlots ExpeditionSlots { get; set; }

[BinaryContent(Name = "nextExpeditionSlotTime", NodeType = BinaryContentTypes.Attribute)]
public HexString NextExpeditionSlotTime { get; set; }

[BinaryContent(Name = "expeditionOverviewEntered", NodeType = BinaryContentTypes.Attribute)]
public HexString ExpeditionOverviewEntered { get; set; }

}
}
