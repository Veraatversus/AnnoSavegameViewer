using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class WaypointListList {

    [BinaryContent(Name = "TimeToTarget", NodeType = BinaryContentTypes.Attribute)]
    public object TimeToTarget { get; set; }

    [BinaryContent(Name = "TargetObject", NodeType = BinaryContentTypes.Node)]
    public WaypointListListTargetObject TargetObject { get; set; }

  }
}