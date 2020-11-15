namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class IncidentTypeDataList {

    [BinaryContent(Name = "Unlocked", NodeType = BinaryContentTypes.Attribute)]
    public object Unlocked { get; set; }

    [BinaryContent(Name = "AreaInfectionChance", NodeType = BinaryContentTypes.Attribute)]
    public object AreaInfectionChance { get; set; }

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public IncidentTypeDataListValue Value { get; set; }

    [BinaryContent(Name = "Incidents", NodeType = BinaryContentTypes.Node)]
    public IncidentTypeDataListIncidents Incidents { get; set; }

    [BinaryContent(Name = "BuildingInfectionChances", NodeType = BinaryContentTypes.Node)]
    public BuildingInfectionChances BuildingInfectionChances { get; set; }
  }
}