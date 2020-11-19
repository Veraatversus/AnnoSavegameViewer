namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ParticipantMessageManager {

    [BinaryContent(Name = "FirstTrainMessageSent", NodeType = BinaryContentTypes.Node)]
    public FirstTrainMessageSent FirstTrainMessageSent { get; set; }

  }
}