using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class FakePingObjectSettingsListObjectFilter {

    [BinaryContent(Name = "ObjectGUID", NodeType = BinaryContentTypes.Attribute)]
    public object ObjectGUID { get; set; }

    [BinaryContent(Name = "ObjectParticipant", NodeType = BinaryContentTypes.Node)]
    public FakePingObjectSettingsListObjectFilterObjectParticipant ObjectParticipant { get; set; }

    [BinaryContent(Name = "IslandNames", NodeType = BinaryContentTypes.Node)]
    public FakePingObjectSettingsListObjectFilterIslandNames IslandNames { get; set; }

    [BinaryContent(Name = "SessionGUID", NodeType = BinaryContentTypes.Node)]
    public FakePingObjectSettingsListObjectFilterSessionGUID SessionGUID { get; set; }

    [BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Node)]
    public FakePingObjectSettingsListObjectFilterQuestID QuestID { get; set; }

  }
}