using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DiscoveryParticipantsList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public DiscoveryParticipantsListValue Value { get; set; }

  }
}