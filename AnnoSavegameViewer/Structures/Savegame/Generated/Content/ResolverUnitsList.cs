using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ResolverUnitsList {

    [BinaryContent(Name = "dummyObject", NodeType = BinaryContentTypes.Attribute)]
    public object DummyObject { get; set; }

    [BinaryContent(Name = "unlockTime", NodeType = BinaryContentTypes.Attribute)]
    public object UnlockTime { get; set; }

    [BinaryContent(Name = "reachedDest", NodeType = BinaryContentTypes.Attribute)]
    public object ReachedDest { get; set; }

    [BinaryContent(Name = "institutionID", NodeType = BinaryContentTypes.Node)]
    public InstitutionID InstitutionID { get; set; }

    [BinaryContent(Name = "id", NodeType = BinaryContentTypes.Node)]
    public Id Id { get; set; }

    [BinaryContent(Name = "incidentType", NodeType = BinaryContentTypes.Node)]
    public IncidentType IncidentType { get; set; }

  }
}