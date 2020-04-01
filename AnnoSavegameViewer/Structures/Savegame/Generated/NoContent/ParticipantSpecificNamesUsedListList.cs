using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ParticipantSpecificNamesUsedListList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ParticipantSpecificNamesUsedListListValue Value { get; set; }

  }
}