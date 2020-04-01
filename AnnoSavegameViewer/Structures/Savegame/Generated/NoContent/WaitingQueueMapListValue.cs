using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class WaitingQueueMapListValue {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public WaitingQueueMapListValueValue Value { get; set; }

  }
}