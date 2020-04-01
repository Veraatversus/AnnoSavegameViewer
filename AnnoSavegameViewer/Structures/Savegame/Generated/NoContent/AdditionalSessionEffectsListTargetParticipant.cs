using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AdditionalSessionEffectsListTargetParticipant {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public AdditionalSessionEffectsListTargetParticipantValue Value { get; set; }

  }
}