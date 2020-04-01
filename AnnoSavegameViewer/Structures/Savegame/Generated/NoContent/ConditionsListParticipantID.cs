using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ConditionsListParticipantID {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ConditionsListParticipantIDValue Value { get; set; }

  }
}