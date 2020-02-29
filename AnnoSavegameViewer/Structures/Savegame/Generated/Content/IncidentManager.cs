using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class IncidentManager {

    [BinaryContent(Name = "NextIncidentID", NodeType = BinaryContentTypes.Attribute)]
    public object NextIncidentID { get; set; }

    [BinaryContent(Name = "Incidents", NodeType = BinaryContentTypes.Node)]
    public Incidents Incidents { get; set; }

    [BinaryContent(Name = "SessionIntervals", NodeType = BinaryContentTypes.Node)]
    public SessionIntervals SessionIntervals { get; set; }

  }
}