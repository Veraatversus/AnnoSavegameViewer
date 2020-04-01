using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ActiveEffectsListTargetParticipant {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ActiveEffectsListTargetParticipantValue Value { get; set; }

  }
}