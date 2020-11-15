namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class Waypoints {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<WaypointsList> WaypointsList { get; set; }

  }
}