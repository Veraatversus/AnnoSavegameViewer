using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class WorkforceTransferManager {

    [BinaryContent(Name = "ParticipantData", NodeType = BinaryContentTypes.Node)]
    public WorkforceTransferManagerParticipantData ParticipantData { get; set; }

  }
}