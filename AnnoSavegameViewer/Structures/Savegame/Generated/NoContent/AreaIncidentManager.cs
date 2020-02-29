using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaIncidentManager {

    [BinaryContent(Name = "incidentTypeData", NodeType = BinaryContentTypes.Node)]
    public IncidentTypeData IncidentTypeData { get; set; }

  }
}