namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ParticipantUnlockManager {

    [BinaryContent(Name = "UnlockData", NodeType = BinaryContentTypes.Node)]
    public UnlockData UnlockData { get; set; }

  }
}