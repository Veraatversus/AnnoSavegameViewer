using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ParticipantMessageManager {

    [BinaryContent(Name = "FirstTrainMessageSent", NodeType = BinaryContentTypes.Node)]
    public FirstTrainMessageSent FirstTrainMessageSent { get; set; }

  }
}