using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MetaEconomy {

    [BinaryContent(Name = "Storage", NodeType = BinaryContentTypes.Node)]
    public Storage Storage { get; set; }

    [BinaryContent(Name = "Transporters", NodeType = BinaryContentTypes.Node)]
    public Transporters Transporters { get; set; }

    [BinaryContent(Name = "MetaEconomyModifiers", NodeType = BinaryContentTypes.Node)]
    public MetaEconomyModifiers MetaEconomyModifiers { get; set; }

    [BinaryContent(Name = "NeedWeightModifierMap", NodeType = BinaryContentTypes.Node)]
    public NeedWeightModifierMap NeedWeightModifierMap { get; set; }

    [BinaryContent(Name = "NeedConsumptionModifierMap", NodeType = BinaryContentTypes.Node)]
    public NeedConsumptionModifierMap NeedConsumptionModifierMap { get; set; }

  }
}