using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PerIncidentDataList {

    [BinaryContent(Name = "protected", NodeType = BinaryContentTypes.Attribute)]
    public object Protected { get; set; }

    [BinaryContent(Name = "infectionChance", NodeType = BinaryContentTypes.Attribute)]
    public object InfectionChance { get; set; }

    [BinaryContent(Name = "infectionChanceDensity", NodeType = BinaryContentTypes.Attribute)]
    public object InfectionChanceDensity { get; set; }

    [BinaryContent(Name = "infectionProximity", NodeType = BinaryContentTypes.Node)]
    public InfectionProximity InfectionProximity { get; set; }

    [BinaryContent(Name = "factors", NodeType = BinaryContentTypes.Node)]
    public Factors Factors { get; set; }

  }
}