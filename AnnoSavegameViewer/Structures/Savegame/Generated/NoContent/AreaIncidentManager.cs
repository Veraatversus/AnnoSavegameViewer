namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class AreaIncidentManager {

    [BinaryContent(Name = "incidentTypeData", NodeType = BinaryContentTypes.Node)]
    public IncidentTypeData IncidentTypeData { get; set; }

  }
}