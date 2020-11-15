namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class WaitingQueueMap {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<WaitingQueueMapList> WaitingQueueMapList { get; set; }

  }
}