using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ConstructionQueueRequests {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ConstructionQueueRequestsList> ConstructionQueueRequestsList { get; set; }

  }
}