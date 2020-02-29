using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Requests {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<RequestsList> RequestsList { get; set; }

  }
}