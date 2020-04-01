using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ObjectSettingsListObjectFilter {

    [BinaryContent(Name = "ObjectGUID", NodeType = BinaryContentTypes.Attribute)]
    public object ObjectGUID { get; set; }

    [BinaryContent(Name = "CheckParticipantID", NodeType = BinaryContentTypes.Attribute)]
    public object CheckParticipantID { get; set; }

    [BinaryContent(Name = "ObjectParticipant", NodeType = BinaryContentTypes.Node)]
    public ObjectSettingsListObjectFilterObjectParticipant ObjectParticipant { get; set; }

    [BinaryContent(Name = "IslandNames", NodeType = BinaryContentTypes.Node)]
    public ObjectSettingsListObjectFilterIslandNames IslandNames { get; set; }

    [BinaryContent(Name = "SessionGUID", NodeType = BinaryContentTypes.Node)]
    public ObjectSettingsListObjectFilterSessionGUID SessionGUID { get; set; }

    [BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Node)]
    public ObjectSettingsListObjectFilterQuestID QuestID { get; set; }

  }
}