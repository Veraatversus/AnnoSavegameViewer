using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class MapGeneratorSettings {

[BinaryContent(Name = "mapSize", NodeType = BinaryContentTypes.Node)]
public MapSize MapSize { get; set; }

[BinaryContent(Name = "mapType", NodeType = BinaryContentTypes.Node)]
public MapType MapType { get; set; }

[BinaryContent(Name = "RandomSeed", NodeType = BinaryContentTypes.Attribute)]
public HexString RandomSeed { get; set; }

[BinaryContent(Name = "region", NodeType = BinaryContentTypes.Node)]
public Region Region { get; set; }

[BinaryContent(Name = "subregion", NodeType = BinaryContentTypes.Node)]
public Subregion Subregion { get; set; }

[BinaryContent(Name = "islandDifficulty", NodeType = BinaryContentTypes.Node)]
public IslandDifficulty IslandDifficulty { get; set; }

[BinaryContent(Name = "fertilityAmount", NodeType = BinaryContentTypes.Node)]
public FertilityAmount FertilityAmount { get; set; }

[BinaryContent(Name = "resourceAmount", NodeType = BinaryContentTypes.Node)]
public ResourceAmount ResourceAmount { get; set; }

[BinaryContent(Name = "islandSize", NodeType = BinaryContentTypes.Node)]
public IslandSize IslandSize { get; set; }

[BinaryContent(Name = "gameType", NodeType = BinaryContentTypes.Node)]
public GameType GameType { get; set; }

[BinaryContent(Name = "PossibleThirdParties", NodeType = BinaryContentTypes.Node)]
public PossibleThirdParties PossibleThirdParties { get; set; }

[BinaryContent(Name = "ThirdPartyPriority", NodeType = BinaryContentTypes.Node)]
public ThirdPartyPriority ThirdPartyPriority { get; set; }

[BinaryContent(Name = "EnforcedMaps", NodeType = BinaryContentTypes.Node)]
public EnforcedMaps EnforcedMaps { get; set; }

}
}
