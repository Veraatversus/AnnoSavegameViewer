namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class Stations {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<StationsList> StationsList { get; set; }

  }
}