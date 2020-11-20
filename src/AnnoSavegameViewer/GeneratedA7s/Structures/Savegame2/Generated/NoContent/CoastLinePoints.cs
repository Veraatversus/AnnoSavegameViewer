namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class CoastLinePoints {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<CoastLinePointsList> CoastLinePointsList { get; set; }

  }
}