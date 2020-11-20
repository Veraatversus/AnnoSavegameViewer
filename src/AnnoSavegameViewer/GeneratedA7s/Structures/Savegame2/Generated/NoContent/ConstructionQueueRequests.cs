namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class ConstructionQueueRequests {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ConstructionQueueRequestsList> ConstructionQueueRequestsList { get; set; }

  }
}