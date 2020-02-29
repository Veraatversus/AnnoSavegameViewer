using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class InfectionChanceTrackerListList {

    [BinaryContent(Name = "Counter", NodeType = BinaryContentTypes.Attribute)]
    public object Counter { get; set; }

    [BinaryContent(Name = "AccumulatedInfectionChance", NodeType = BinaryContentTypes.Attribute)]
    public object AccumulatedInfectionChance { get; set; }

    [BinaryContent(Name = "HealingUnitSent", NodeType = BinaryContentTypes.Attribute)]
    public object HealingUnitSent { get; set; }

  }
}