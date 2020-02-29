using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class OwnedBuildings {

    [BinaryContent(Name = "CountsPerCategory", NodeType = BinaryContentTypes.Attribute)]
    public object CountsPerCategory { get; set; }

    [BinaryContent(Name = "HarborBuildingCount", NodeType = BinaryContentTypes.Attribute)]
    public object HarborBuildingCount { get; set; }

    [BinaryContent(Name = "BuildingsByID", NodeType = BinaryContentTypes.Node)]
    public BuildingsByID BuildingsByID { get; set; }

    [BinaryContent(Name = "BuildingsByGUID", NodeType = BinaryContentTypes.Node)]
    public BuildingsByGUID BuildingsByGUID { get; set; }

    [BinaryContent(Name = "VirtualBuildings", NodeType = BinaryContentTypes.Node)]
    public VirtualBuildings VirtualBuildings { get; set; }

  }
}