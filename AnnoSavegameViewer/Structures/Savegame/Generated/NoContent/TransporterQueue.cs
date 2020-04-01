using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class TransporterQueue {

    [BinaryContent(Name = "QueuedTransporters", NodeType = BinaryContentTypes.Node)]
    public QueuedTransporters QueuedTransporters { get; set; }

    [BinaryContent(Name = "ProcessingTransporters", NodeType = BinaryContentTypes.Node)]
    public ProcessingTransporters ProcessingTransporters { get; set; }

  }
}