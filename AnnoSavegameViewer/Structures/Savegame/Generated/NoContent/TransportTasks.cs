namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class TransportTasks {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<TransportTasksList> TransportTasksList { get; set; }

  }
}