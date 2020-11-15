namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class Requests {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<RequestsList> RequestsList { get; set; }

  }
}