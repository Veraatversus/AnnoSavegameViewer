using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class WorkforceTransferManager {

    [BinaryContent(Name = "ParticipantData", NodeType = BinaryContentTypes.Node)]
    public WorkforceTransferManagerParticipantData ParticipantData { get; set; }

  }
}