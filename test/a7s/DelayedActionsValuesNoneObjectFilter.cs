using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class DelayedActionsValuesNoneObjectFilter {

[BinaryContent(Name = "ObjectGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString ObjectGUID { get; set; }

[BinaryContent(Name = "ObjectParticipant", NodeType = BinaryContentTypes.Node)]
public ValuesNoneObjectFilterObjectParticipant ObjectParticipant { get; set; }

[BinaryContent(Name = "IslandNames", NodeType = BinaryContentTypes.Node)]
public ValuesNoneObjectFilterIslandNames IslandNames { get; set; }

[BinaryContent(Name = "SessionGUID", NodeType = BinaryContentTypes.Node)]
public ValuesNoneObjectFilterSessionGUID SessionGUID { get; set; }

[BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Node)]
public ValuesNoneObjectFilterQuestID QuestID { get; set; }

}
}
