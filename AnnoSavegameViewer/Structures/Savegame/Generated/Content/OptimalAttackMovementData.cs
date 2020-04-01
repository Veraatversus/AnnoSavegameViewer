using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class OptimalAttackMovementData {

    [BinaryContent(Name = "OptimalAngleWS", NodeType = BinaryContentTypes.Attribute)]
    public object OptimalAngleWS { get; set; }

    [BinaryContent(Name = "OptimalDistanceWS", NodeType = BinaryContentTypes.Attribute)]
    public object OptimalDistanceWS { get; set; }

  }
}