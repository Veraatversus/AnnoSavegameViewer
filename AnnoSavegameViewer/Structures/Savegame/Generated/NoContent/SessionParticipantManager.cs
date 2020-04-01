using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SessionParticipantManager {

    [BinaryContent(Name = "ParticipantIDToObjects", NodeType = BinaryContentTypes.Node)]
    public ParticipantIDToObjects ParticipantIDToObjects { get; set; }

  }
}