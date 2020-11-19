namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class CityLayoutBlock {

    [BinaryContent(Name = "Rect", NodeType = BinaryContentTypes.Attribute)]
    public object Rect { get; set; }

    [BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
    public object ID { get; set; }

    [BinaryContent(Name = "BlockedTiles", NodeType = BinaryContentTypes.Attribute)]
    public object BlockedTiles { get; set; }

    [BinaryContent(Name = "AllStreetsFinalized", NodeType = BinaryContentTypes.Attribute)]
    public object AllStreetsFinalized { get; set; }

    [BinaryContent(Name = "OneStreetFinalized", NodeType = BinaryContentTypes.Attribute)]
    public object OneStreetFinalized { get; set; }

    [BinaryContent(Name = "ContainsNonOrnamentals", NodeType = BinaryContentTypes.Attribute)]
    public object ContainsNonOrnamentals { get; set; }

    [BinaryContent(Name = "ReferencePos", NodeType = BinaryContentTypes.Attribute)]
    public object ReferencePos { get; set; }

    [BinaryContent(Name = "MaxCivLevel", NodeType = BinaryContentTypes.Attribute)]
    public object MaxCivLevel { get; set; }

    [BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Node)]
    public CityLayoutBlockType Type { get; set; }

    [BinaryContent(Name = "RegularBuildings", NodeType = BinaryContentTypes.Node)]
    public CityLayoutBlockRegularBuildings RegularBuildings { get; set; }

    [BinaryContent(Name = "ModulesAndOrnaments", NodeType = BinaryContentTypes.Node)]
    public CityLayoutBlockModulesAndOrnaments ModulesAndOrnaments { get; set; }

    [BinaryContent(Name = "NeededPublic", NodeType = BinaryContentTypes.Node)]
    public NeededPublic NeededPublic { get; set; }

    [BinaryContent(Name = "ProvidedPublic", NodeType = BinaryContentTypes.Node)]
    public ProvidedPublic ProvidedPublic { get; set; }
  }
}