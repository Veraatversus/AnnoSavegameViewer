using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CoastLinePoints {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<CoastLinePointsList> CoastLinePointsList { get; set; }

  }
}