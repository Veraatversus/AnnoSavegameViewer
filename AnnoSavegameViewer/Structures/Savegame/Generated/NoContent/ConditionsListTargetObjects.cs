using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ConditionsListTargetObjects {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public ConditionsListTargetObjectsList ConditionsListTargetObjectsList { get; set; }

  }
}