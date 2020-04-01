using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class QueuedTransfersListState {

    [BinaryContent(Name = "State", NodeType = BinaryContentTypes.Attribute)]
    public object State { get; set; }

  }
}