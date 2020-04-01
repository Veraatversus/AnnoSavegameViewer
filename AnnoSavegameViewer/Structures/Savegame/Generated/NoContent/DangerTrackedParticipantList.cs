using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DangerTrackedParticipantList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public DangerTrackedParticipantListValue Value { get; set; }

  }
}