using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class NoneObjectFilter {

[BinaryContent(Name = "ObjectParticipant", NodeType = BinaryContentTypes.Node)]
public ObjectFilterObjectParticipant ObjectParticipant { get; set; }

[BinaryContent(Name = "IslandNames", NodeType = BinaryContentTypes.Node)]
public ObjectFilterIslandNames IslandNames { get; set; }

[BinaryContent(Name = "SessionGUID", NodeType = BinaryContentTypes.Node)]
public ObjectFilterSessionGUID SessionGUID { get; set; }

[BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Node)]
public ObjectFilterQuestID QuestID { get; set; }

}
}
