namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class Crises {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<CrisesList> CrisesList { get; set; }

  }
}