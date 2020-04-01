using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PreviousRejectsList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public PreviousRejectsListValue Value { get; set; }

  }
}