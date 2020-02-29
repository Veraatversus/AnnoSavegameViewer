using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class WorkforceTransferManagerParticipantData {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<WorkforceTransferManagerParticipantDataList> WorkforceTransferManagerParticipantDataList { get; set; }

  }
}