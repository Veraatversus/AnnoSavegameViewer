using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class InfectionChanceTrackerListList {

    [BinaryContent(Name = "Counter", NodeType = BinaryContentTypes.Attribute)]
    public object Counter { get; set; }

    [BinaryContent(Name = "AccumulatedInfectionChance", NodeType = BinaryContentTypes.Attribute)]
    public object AccumulatedInfectionChance { get; set; }

  }
}