using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class TargetParticipant {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public TargetParticipantValue Value { get; set; }

  }
}