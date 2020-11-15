namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class NewspaperManager {

    [BinaryContent(Name = "IDManager", NodeType = BinaryContentTypes.Node)]
    public NewspaperManagerIDManager IDManager { get; set; }

    [BinaryContent(Name = "ParticipantData", NodeType = BinaryContentTypes.Node)]
    public ParticipantData ParticipantData { get; set; }

  }
}