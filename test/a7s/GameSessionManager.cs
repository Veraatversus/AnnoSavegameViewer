using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class GameSessionManager {

[BinaryContent(Name = "MapTemplate", NodeType = BinaryContentTypes.Node)]
public MapTemplate MapTemplate { get; set; }

[BinaryContent(Name = "SessionTotalTime", NodeType = BinaryContentTypes.Attribute)]
public TimeSpan SessionTotalTime { get; set; }

[BinaryContent(Name = "SessionGameCount", NodeType = BinaryContentTypes.Attribute)]
public HexString SessionGameCount { get; set; }

[BinaryContent(Name = "PeerSpecificData", NodeType = BinaryContentTypes.Node)]
public PeerSpecificData PeerSpecificData { get; set; }

[BinaryContent(Name = "SessionRandomManager", NodeType = BinaryContentTypes.Node)]
public SessionRandomManager SessionRandomManager { get; set; }

[BinaryContent(Name = "TerrainManager", NodeType = BinaryContentTypes.Node)]
public TerrainManager TerrainManager { get; set; }

[BinaryContent(Name = "SessionCameraManager", NodeType = BinaryContentTypes.Node)]
public SessionCameraManager SessionCameraManager { get; set; }

[BinaryContent(Name = "MessageManager", NodeType = BinaryContentTypes.Node)]
public MessageManager MessageManager { get; set; }

[BinaryContent(Name = "GameObjectManager", NodeType = BinaryContentTypes.Node)]
public GameObjectManager GameObjectManager { get; set; }

[BinaryContent(Name = "SessionParticipantManager", NodeType = BinaryContentTypes.Node)]
public SessionParticipantManager SessionParticipantManager { get; set; }

[BinaryContent(Name = "IslandManager", NodeType = BinaryContentTypes.Node)]
public IslandManager IslandManager { get; set; }

[BinaryContent(Name = "MinimapManager", NodeType = BinaryContentTypes.Node)]
public MinimapManager MinimapManager { get; set; }

[BinaryContent(Name = "SessionCoastManager", NodeType = BinaryContentTypes.Node)]
public SessionCoastManager SessionCoastManager { get; set; }

[BinaryContent(Name = "WorldManager", NodeType = BinaryContentTypes.Node)]
public WorldManager WorldManager { get; set; }

[BinaryContent(Name = "PathManager", NodeType = BinaryContentTypes.Node)]
public PathManager PathManager { get; set; }

[BinaryContent(Name = "SessionEconomyManager", NodeType = BinaryContentTypes.Node)]
public SessionEconomyManager SessionEconomyManager { get; set; }

[BinaryContent(Name = "DiscoveryManager", NodeType = BinaryContentTypes.Node)]
public DiscoveryManager DiscoveryManager { get; set; }

[BinaryContent(Name = "RegrowManager", NodeType = BinaryContentTypes.Node)]
public RegrowManager RegrowManager { get; set; }

[BinaryContent(Name = "SessionSoundManager", NodeType = BinaryContentTypes.Node)]
public SessionSoundManager SessionSoundManager { get; set; }

[BinaryContent(Name = "ActiveTradeManager", NodeType = BinaryContentTypes.Node)]
public ActiveTradeManager ActiveTradeManager { get; set; }

[BinaryContent(Name = "StreetOverlayManager", NodeType = BinaryContentTypes.Node)]
public StreetOverlayManager StreetOverlayManager { get; set; }

[BinaryContent(Name = "SelectionManager", NodeType = BinaryContentTypes.Node)]
public SelectionManager SelectionManager { get; set; }

[BinaryContent(Name = "IncidentManager", NodeType = BinaryContentTypes.Node)]
public IncidentManager IncidentManager { get; set; }

[BinaryContent(Name = "CameraSequenceManager", NodeType = BinaryContentTypes.Node)]
public CameraSequenceManager CameraSequenceManager { get; set; }

[BinaryContent(Name = "AIUnitManager", NodeType = BinaryContentTypes.Node)]
public AIUnitManager AIUnitManager { get; set; }

[BinaryContent(Name = "AIConstructionManager", NodeType = BinaryContentTypes.Node)]
public AIConstructionManager AIConstructionManager { get; set; }

[BinaryContent(Name = "AnimalManager", NodeType = BinaryContentTypes.Node)]
public AnimalManager AnimalManager { get; set; }

[BinaryContent(Name = "CSlotManager", NodeType = BinaryContentTypes.Node)]
public CSlotManager CSlotManager { get; set; }

[BinaryContent(Name = "VisitorManager", NodeType = BinaryContentTypes.Node)]
public VisitorManager VisitorManager { get; set; }

[BinaryContent(Name = "ItemSessionManager", NodeType = BinaryContentTypes.Node)]
public ItemSessionManager ItemSessionManager { get; set; }

[BinaryContent(Name = "MilitaryManager", NodeType = BinaryContentTypes.Node)]
public MilitaryManager MilitaryManager { get; set; }

[BinaryContent(Name = "BlueprintManager", NodeType = BinaryContentTypes.Node)]
public BlueprintManager BlueprintManager { get; set; }

[BinaryContent(Name = "LoadingPierManager", NodeType = BinaryContentTypes.Node)]
public LoadingPierManager LoadingPierManager { get; set; }

[BinaryContent(Name = "SessionFreeAreaProductivityManager", NodeType = BinaryContentTypes.Node)]
public SessionFreeAreaProductivityManager SessionFreeAreaProductivityManager { get; set; }

[BinaryContent(Name = "WorkforceTransferManager", NodeType = BinaryContentTypes.Node)]
public WorkforceTransferManager WorkforceTransferManager { get; set; }

[BinaryContent(Name = "IrrigationManager", NodeType = BinaryContentTypes.Node)]
public IrrigationManager IrrigationManager { get; set; }

[BinaryContent(Name = "CoopPingManager", NodeType = BinaryContentTypes.Node)]
public CoopPingManager CoopPingManager { get; set; }

[BinaryContent(Name = "AreaManagers", NodeType = BinaryContentTypes.Node)]
public AreaManagers AreaManagers { get; set; }

[BinaryContent(Name = "AreaLinks", NodeType = BinaryContentTypes.Node)]
public AreaLinks AreaLinks { get; set; }

[BinaryContent(Name = "AreaInfo", NodeType = BinaryContentTypes.Node)]
public AreaInfo AreaInfo { get; set; }

}
}
