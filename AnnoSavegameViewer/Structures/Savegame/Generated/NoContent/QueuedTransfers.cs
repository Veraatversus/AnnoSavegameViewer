using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class QueuedTransfers {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<QueuedTransfersList> QueuedTransfersList { get; set; }

  }
}