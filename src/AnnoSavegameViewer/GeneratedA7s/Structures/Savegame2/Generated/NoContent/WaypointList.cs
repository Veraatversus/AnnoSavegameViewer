namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class WaypointList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<WaypointListList> WaypointListList { get; set; }

  }
}