using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ParticipantMessageManager {

    [BinaryContent(Name = "FirstTrainMessageSent", NodeType = BinaryContentTypes.Node)]
    public FirstTrainMessageSent FirstTrainMessageSent { get; set; }

  }
}