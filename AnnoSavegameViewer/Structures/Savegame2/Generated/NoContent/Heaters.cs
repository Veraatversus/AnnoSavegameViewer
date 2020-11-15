namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class Heaters {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<HeatersList> HeatersList { get; set; }

  }
}