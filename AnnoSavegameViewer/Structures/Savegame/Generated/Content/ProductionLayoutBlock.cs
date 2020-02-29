using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ProductionLayoutBlock {

    [BinaryContent(Name = "Rect", NodeType = BinaryContentTypes.Attribute)]
    public object Rect { get; set; }

    [BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
    public object ID { get; set; }

    [BinaryContent(Name = "BlockedTiles", NodeType = BinaryContentTypes.Attribute)]
    public object BlockedTiles { get; set; }

    [BinaryContent(Name = "ContainsNonOrnamentals", NodeType = BinaryContentTypes.Attribute)]
    public object ContainsNonOrnamentals { get; set; }

    [BinaryContent(Name = "AllStreetsFinalized", NodeType = BinaryContentTypes.Attribute)]
    public object AllStreetsFinalized { get; set; }

    [BinaryContent(Name = "OneStreetFinalized", NodeType = BinaryContentTypes.Attribute)]
    public object OneStreetFinalized { get; set; }

    [BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Node)]
    public ProductionLayoutBlockType Type { get; set; }

    [BinaryContent(Name = "RegularBuildings", NodeType = BinaryContentTypes.Node)]
    public RegularBuildings RegularBuildings { get; set; }

    [BinaryContent(Name = "ModulesAndOrnaments", NodeType = BinaryContentTypes.Node)]
    public ModulesAndOrnaments ModulesAndOrnaments { get; set; }

    [BinaryContent(Name = "BlacklistedGUIDs", NodeType = BinaryContentTypes.Node)]
    public BlacklistedGUIDs BlacklistedGUIDs { get; set; }

    [BinaryContent(Name = "ProductionGUIDs", NodeType = BinaryContentTypes.Node)]
    public ProductionGUIDs ProductionGUIDs { get; set; }

  }
}