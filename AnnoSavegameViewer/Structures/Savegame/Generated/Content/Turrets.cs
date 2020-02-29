using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Turrets {

    [BinaryContent(Name = "count", NodeType = BinaryContentTypes.Attribute)]
    public object Count { get; set; }

    [BinaryContent(Name = "CanFireAtTarget", NodeType = BinaryContentTypes.Attribute)]
    public List<object> CanFireAtTarget { get; set; }

    [BinaryContent(Name = "enemyFocusDuration", NodeType = BinaryContentTypes.Attribute)]
    public object EnemyFocusDuration { get; set; }

  }
}