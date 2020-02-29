using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MetaParticipantMessages {

    [BinaryContent(Name = "TriggerCount", NodeType = BinaryContentTypes.Attribute)]
    public object TriggerCount { get; set; }

    [BinaryContent(Name = "Deactivated", NodeType = BinaryContentTypes.Attribute)]
    public object Deactivated { get; set; }

    [BinaryContent(Name = "MessageStates", NodeType = BinaryContentTypes.Node)]
    public List<MessageStates> MessageStates { get; set; }

    [BinaryContent(Name = "UniqueMessagesSent", NodeType = BinaryContentTypes.Node)]
    public UniqueMessagesSent UniqueMessagesSent { get; set; }

  }
}