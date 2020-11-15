namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class OccupyTimes {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<OccupyTimesList> OccupyTimesList { get; set; }

  }
}