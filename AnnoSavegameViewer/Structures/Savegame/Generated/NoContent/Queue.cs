using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Queue {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public QueueList QueueList { get; set; }

  }
}