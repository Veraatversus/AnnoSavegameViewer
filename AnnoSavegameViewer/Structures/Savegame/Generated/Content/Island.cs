using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Island {

    [BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
    public object AreaID { get; set; }

    [BinaryContent(Name = "TileCount", NodeType = BinaryContentTypes.Attribute)]
    public object TileCount { get; set; }

    [BinaryContent(Name = "KontorObject", NodeType = BinaryContentTypes.Attribute)]
    public object KontorObject { get; set; }

    [BinaryContent(Name = "KontorPos", NodeType = BinaryContentTypes.Attribute)]
    public object KontorPos { get; set; }

    [BinaryContent(Name = "IslandRoles", NodeType = BinaryContentTypes.Attribute)]
    public object IslandRoles { get; set; }

    [BinaryContent(Name = "AreaLayout", NodeType = BinaryContentTypes.Node)]
    public AreaLayout AreaLayout { get; set; }

    [BinaryContent(Name = "OwnedBuildings", NodeType = BinaryContentTypes.Node)]
    public OwnedBuildings OwnedBuildings { get; set; }

    [BinaryContent(Name = "ResourceBalance", NodeType = BinaryContentTypes.Node)]
    public ResourceBalance ResourceBalance { get; set; }

    [BinaryContent(Name = "CityHandler", NodeType = BinaryContentTypes.Node)]
    public CityHandler CityHandler { get; set; }

    [BinaryContent(Name = "HarborHandler", NodeType = BinaryContentTypes.Node)]
    public HarborHandler HarborHandler { get; set; }

    [BinaryContent(Name = "ResourceSatisfaction", NodeType = BinaryContentTypes.Node)]
    public ResourceSatisfaction ResourceSatisfaction { get; set; }

    [BinaryContent(Name = "SettleApproach", NodeType = BinaryContentTypes.Node)]
    public SettleApproach SettleApproach { get; set; }

    [BinaryContent(Name = "DistanceApprox", NodeType = BinaryContentTypes.Node)]
    public DistanceApprox DistanceApprox { get; set; }

  }
}