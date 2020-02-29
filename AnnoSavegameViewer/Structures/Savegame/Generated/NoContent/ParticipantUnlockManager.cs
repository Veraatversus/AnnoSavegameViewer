using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ParticipantUnlockManager {

    [BinaryContent(Name = "UnlockData", NodeType = BinaryContentTypes.Node)]
    public UnlockData UnlockData { get; set; }

  }
}