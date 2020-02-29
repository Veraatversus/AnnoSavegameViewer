using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class QueuedTransporters {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<QueuedTransportersList> QueuedTransportersList { get; set; }

  }
}