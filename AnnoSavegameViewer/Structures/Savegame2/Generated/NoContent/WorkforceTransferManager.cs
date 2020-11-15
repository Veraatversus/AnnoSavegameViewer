namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class WorkforceTransferManager {

    [BinaryContent(Name = "ParticipantData", NodeType = BinaryContentTypes.Node)]
    public WorkforceTransferManagerParticipantData ParticipantData { get; set; }

  }
}