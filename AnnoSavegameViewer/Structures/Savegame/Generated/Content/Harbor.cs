using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Harbor {

    [BinaryContent(Name = "connected", NodeType = BinaryContentTypes.Attribute)]
    public object Connected { get; set; }

    [BinaryContent(Name = "boundingBox", NodeType = BinaryContentTypes.Attribute)]
    public object BoundingBox { get; set; }

    [BinaryContent(Name = "coastBoundingBox", NodeType = BinaryContentTypes.Attribute)]
    public object CoastBoundingBox { get; set; }

    [BinaryContent(Name = "unprotectedBuildings", NodeType = BinaryContentTypes.Attribute)]
    public object UnprotectedBuildings { get; set; }

    [BinaryContent(Name = "referencePos", NodeType = BinaryContentTypes.Attribute)]
    public object ReferencePos { get; set; }

    [BinaryContent(Name = "missingSecurity", NodeType = BinaryContentTypes.Attribute)]
    public object MissingSecurity { get; set; }

    [BinaryContent(Name = "totalNeededSecurity", NodeType = BinaryContentTypes.Attribute)]
    public object TotalNeededSecurity { get; set; }

    [BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
    public object ID { get; set; }

    [BinaryContent(Name = "pierCount", NodeType = BinaryContentTypes.Attribute)]
    public object PierCount { get; set; }

    [BinaryContent(Name = "pierBuildingCount", NodeType = BinaryContentTypes.Attribute)]
    public object PierBuildingCount { get; set; }

    [BinaryContent(Name = "coastLinePoints", NodeType = BinaryContentTypes.Node)]
    public CoastLinePoints CoastLinePoints { get; set; }

    [BinaryContent(Name = "driveways", NodeType = BinaryContentTypes.Node)]
    public Driveways Driveways { get; set; }

    [BinaryContent(Name = "buildings", NodeType = BinaryContentTypes.Node)]
    public Buildings Buildings { get; set; }

    [BinaryContent(Name = "buildingsPerGuid", NodeType = BinaryContentTypes.Node)]
    public BuildingsPerGuid BuildingsPerGuid { get; set; }

    [BinaryContent(Name = "defenses", NodeType = BinaryContentTypes.Node)]
    public Defenses Defenses { get; set; }

    [BinaryContent(Name = "harborOffices", NodeType = BinaryContentTypes.Node)]
    public HarborOffices HarborOffices { get; set; }

  }
}