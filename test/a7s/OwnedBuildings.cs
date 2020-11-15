using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class OwnedBuildings {

[BinaryContent(Name = "BuildingsByID", NodeType = BinaryContentTypes.Node)]
public BuildingsByID BuildingsByID { get; set; }

[BinaryContent(Name = "BuildingsByGUID", NodeType = BinaryContentTypes.Node)]
public BuildingsByGUID BuildingsByGUID { get; set; }

[BinaryContent(Name = "VirtualBuildings", NodeType = BinaryContentTypes.Node)]
public VirtualBuildings VirtualBuildings { get; set; }

[BinaryContent(Name = "CountsPerCategory", NodeType = BinaryContentTypes.Attribute)]
public HexString CountsPerCategory { get; set; }

[BinaryContent(Name = "HarborBuildingCount", NodeType = BinaryContentTypes.Attribute)]
public HexString HarborBuildingCount { get; set; }

}
}
