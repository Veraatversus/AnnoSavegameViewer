using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ObjectFilter {

    [BinaryContent(Name = "ObjectGUID", NodeType = BinaryContentTypes.Attribute)]
    public object ObjectGUID { get; set; }

    [BinaryContent(Name = "ObjectParticipant", NodeType = BinaryContentTypes.Node)]
    public ObjectParticipant ObjectParticipant { get; set; }

    [BinaryContent(Name = "IslandNames", NodeType = BinaryContentTypes.Node)]
    public IslandNames IslandNames { get; set; }

    [BinaryContent(Name = "SessionGUID", NodeType = BinaryContentTypes.Node)]
    public SessionGUID SessionGUID { get; set; }

    [BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Node)]
    public ObjectFilterQuestID QuestID { get; set; }

  }
}