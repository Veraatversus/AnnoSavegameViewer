namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class IncidentManager {

    #region Public Properties

    [BinaryContent(Name = "NextIncidentID", NodeType = BinaryContentTypes.Attribute)]
    public object NextIncidentID { get; set; }

    [BinaryContent(Name = "Incidents", NodeType = BinaryContentTypes.Node)]
    public Incidents Incidents { get; set; }

    [BinaryContent(Name = "SessionIntervals", NodeType = BinaryContentTypes.Node)]
    public SessionIntervals SessionIntervals { get; set; }

    #endregion Public Properties
  }
}