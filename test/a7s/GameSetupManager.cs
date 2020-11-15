using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class GameSetupManager {

[BinaryContent(Name = "PeerCount", NodeType = BinaryContentTypes.Attribute)]
public HexString PeerCount { get; set; }

[BinaryContent(Name = "Peers", NodeType = BinaryContentTypes.Node)]
public Peers Peers { get; set; }

[BinaryContent(Name = "GameSeed", NodeType = BinaryContentTypes.Attribute)]
public UInt32 GameSeed { get; set; }

[BinaryContent(Name = "Customizable", NodeType = BinaryContentTypes.Attribute)]
public HexString Customizable { get; set; }

[BinaryContent(Name = "Maps", NodeType = BinaryContentTypes.Node)]
public Maps Maps { get; set; }

[BinaryContent(Name = "GameSetupDifficulty", NodeType = BinaryContentTypes.Node)]
public GameSetupDifficulty GameSetupDifficulty { get; set; }

[BinaryContent(Name = "SavegameFolderW", NodeType = BinaryContentTypes.Attribute)]
public String SavegameFolderW { get; set; }

[BinaryContent(Name = "ActiveDLCs", NodeType = BinaryContentTypes.Node)]
public ActiveDLCs ActiveDLCs { get; set; }

[BinaryContent(Name = "ActiveHappyDayEvents", NodeType = BinaryContentTypes.Attribute)]
public HexString ActiveHappyDayEvents { get; set; }

[BinaryContent(Name = "SetupConstructionCostRefund", NodeType = BinaryContentTypes.Node)]
public SetupConstructionCostRefund SetupConstructionCostRefund { get; set; }

[BinaryContent(Name = "SetupDistributionWorkforce", NodeType = BinaryContentTypes.Node)]
public SetupDistributionWorkforce SetupDistributionWorkforce { get; set; }

[BinaryContent(Name = "SetupFertility", NodeType = BinaryContentTypes.Node)]
public SetupFertility SetupFertility { get; set; }

[BinaryContent(Name = "SetupHostileTakeover", NodeType = BinaryContentTypes.Node)]
public SetupHostileTakeover SetupHostileTakeover { get; set; }

[BinaryContent(Name = "SetupInactiveCosts", NodeType = BinaryContentTypes.Node)]
public SetupInactiveCosts SetupInactiveCosts { get; set; }

[BinaryContent(Name = "SetupIncidents", NodeType = BinaryContentTypes.Node)]
public SetupIncidents SetupIncidents { get; set; }

[BinaryContent(Name = "SetupLossCondition", NodeType = BinaryContentTypes.Node)]
public SetupLossCondition SetupLossCondition { get; set; }

[BinaryContent(Name = "SetupOptionalQuestFrequency", NodeType = BinaryContentTypes.Node)]
public SetupOptionalQuestFrequency SetupOptionalQuestFrequency { get; set; }

[BinaryContent(Name = "SetupOptionalQuestRewards", NodeType = BinaryContentTypes.Node)]
public SetupOptionalQuestRewards SetupOptionalQuestRewards { get; set; }

[BinaryContent(Name = "SetupOptionalQuestTimeout", NodeType = BinaryContentTypes.Node)]
public SetupOptionalQuestTimeout SetupOptionalQuestTimeout { get; set; }

[BinaryContent(Name = "SetupRawMaterial", NodeType = BinaryContentTypes.Node)]
public SetupRawMaterial SetupRawMaterial { get; set; }

[BinaryContent(Name = "SetupRelocateBuildings", NodeType = BinaryContentTypes.Node)]
public SetupRelocateBuildings SetupRelocateBuildings { get; set; }

[BinaryContent(Name = "SetupRevealedMap", NodeType = BinaryContentTypes.Node)]
public SetupRevealedMap SetupRevealedMap { get; set; }

[BinaryContent(Name = "SetupRevenue", NodeType = BinaryContentTypes.Node)]
public SetupRevenue SetupRevenue { get; set; }

[BinaryContent(Name = "SetupStartCredits", NodeType = BinaryContentTypes.Node)]
public SetupStartCredits SetupStartCredits { get; set; }

[BinaryContent(Name = "SetupStartSession", NodeType = BinaryContentTypes.Node)]
public SetupStartSession SetupStartSession { get; set; }

[BinaryContent(Name = "SetupStartSessionIslandDifficulty", NodeType = BinaryContentTypes.Node)]
public SetupStartSessionIslandDifficulty SetupStartSessionIslandDifficulty { get; set; }

[BinaryContent(Name = "SetupStartSessionIslandSize", NodeType = BinaryContentTypes.Node)]
public SetupStartSessionIslandSize SetupStartSessionIslandSize { get; set; }

[BinaryContent(Name = "SetupStartShips", NodeType = BinaryContentTypes.Node)]
public SetupStartShips SetupStartShips { get; set; }

[BinaryContent(Name = "SetupStartWithKontor", NodeType = BinaryContentTypes.Node)]
public SetupStartWithKontor SetupStartWithKontor { get; set; }

[BinaryContent(Name = "SetupTraderRefillRate", NodeType = BinaryContentTypes.Node)]
public SetupTraderRefillRate SetupTraderRefillRate { get; set; }

[BinaryContent(Name = "SetupInfluence", NodeType = BinaryContentTypes.Node)]
public SetupInfluence SetupInfluence { get; set; }

[BinaryContent(Name = "ThirdParties", NodeType = BinaryContentTypes.Node)]
public ThirdParties ThirdParties { get; set; }

[BinaryContent(Name = "SecondParties", NodeType = BinaryContentTypes.Node)]
public SecondParties SecondParties { get; set; }

[BinaryContent(Name = "SetupVictoryConditionMonuments", NodeType = BinaryContentTypes.Node)]
public SetupVictoryConditionMonuments SetupVictoryConditionMonuments { get; set; }

[BinaryContent(Name = "SetupVictoryConditionInvestors", NodeType = BinaryContentTypes.Node)]
public SetupVictoryConditionInvestors SetupVictoryConditionInvestors { get; set; }

[BinaryContent(Name = "SetupVictoryConditionPopulation", NodeType = BinaryContentTypes.Node)]
public SetupVictoryConditionPopulation SetupVictoryConditionPopulation { get; set; }

[BinaryContent(Name = "SetupVictoryConditionWealth", NodeType = BinaryContentTypes.Node)]
public SetupVictoryConditionWealth SetupVictoryConditionWealth { get; set; }

[BinaryContent(Name = "SetupVictoryConditionIncome", NodeType = BinaryContentTypes.Node)]
public SetupVictoryConditionIncome SetupVictoryConditionIncome { get; set; }

[BinaryContent(Name = "SetupVictoryConditionAllOrOne", NodeType = BinaryContentTypes.Node)]
public SetupVictoryConditionAllOrOne SetupVictoryConditionAllOrOne { get; set; }

[BinaryContent(Name = "SetupVictoryConditionDiplomacy", NodeType = BinaryContentTypes.Node)]
public SetupVictoryConditionDiplomacy SetupVictoryConditionDiplomacy { get; set; }

[BinaryContent(Name = "SetupMapType", NodeType = BinaryContentTypes.Node)]
public SetupMapType SetupMapType { get; set; }

[BinaryContent(Name = "SelectedDifficultyPreset", NodeType = BinaryContentTypes.Node)]
public SelectedDifficultyPreset SelectedDifficultyPreset { get; set; }

}
}
