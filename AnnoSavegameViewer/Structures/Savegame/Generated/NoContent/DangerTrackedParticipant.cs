using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DangerTrackedParticipant {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public DangerTrackedParticipantList DangerTrackedParticipantList { get; set; }

  }
}