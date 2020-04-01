using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PairParticipantID {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public PairParticipantIDValue Value { get; set; }

  }
}