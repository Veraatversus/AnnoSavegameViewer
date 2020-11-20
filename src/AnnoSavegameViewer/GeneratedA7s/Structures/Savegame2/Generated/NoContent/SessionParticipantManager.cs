namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class SessionParticipantManager {

    [BinaryContent(Name = "ParticipantIDToObjects", NodeType = BinaryContentTypes.Node)]
    public ParticipantIDToObjects ParticipantIDToObjects { get; set; }

  }
}