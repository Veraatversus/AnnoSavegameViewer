using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class GameSessionManager {

    [BinaryContent(Name = "SessionTotalTime", NodeType = BinaryContentTypes.Attribute)]
    public object SessionTotalTime { get; set; }

    [BinaryContent(Name = "SessionGameCount", NodeType = BinaryContentTypes.Attribute)]
    public object SessionGameCount { get; set; }

    [BinaryContent(Name = "MapTemplate", NodeType = BinaryContentTypes.Node)]
    public MapTemplate MapTemplate { get; set; }

    [BinaryContent(Name = "PeerSpecificData", NodeType = BinaryContentTypes.Node)]
    public PeerSpecificData PeerSpecificData { get; set; }

    //[BinaryContent(Name = "SessionRandomManager", NodeType = BinaryContentType.Node)]
    //public SessionRandomManager SessionRandomManager { get; set; }

    //[BinaryContent(Name = "TerrainManager", NodeType = BinaryContentType.Node)]
    //public TerrainManager TerrainManager { get; set; }

    //[BinaryContent(Name = "SessionCameraManager", NodeType = BinaryContentType.Node)]
    //public SessionCameraManager SessionCameraManager { get; set; }

    //[BinaryContent(Name = "MessageManager", NodeType = BinaryContentType.Node)]
    //public MessageManager MessageManager { get; set; }

    [BinaryContent(Name = "GameObjectManager", NodeType = BinaryContentTypes.Node)]
    public GameObjectManager GameObjectManager { get; set; }

    [BinaryContent(Name = "SessionParticipantManager", NodeType = BinaryContentTypes.Node)]
    public SessionParticipantManager SessionParticipantManager { get; set; }

    [BinaryContent(Name = "IslandManager", NodeType = BinaryContentTypes.Node)]
    public IslandManager IslandManager { get; set; }

    //[BinaryContent(Name = "MinimapManager", NodeType = BinaryContentType.Node)]
    //public MinimapManager MinimapManager { get; set; }

    //[BinaryContent(Name = "SessionCoastManager", NodeType = BinaryContentType.Node)]
    //public SessionCoastManager SessionCoastManager { get; set; }

    //[BinaryContent(Name = "WorldManager", NodeType = BinaryContentType.Node)]
    //public WorldManager WorldManager { get; set; }

    //[BinaryContent(Name = "PathManager", NodeType = BinaryContentType.Node)]
    //public PathManager PathManager { get; set; }

    [BinaryContent(Name = "SessionEconomyManager", NodeType = BinaryContentTypes.Node)]
    public SessionEconomyManager SessionEconomyManager { get; set; }

    //[BinaryContent(Name = "DiscoveryManager", NodeType = BinaryContentType.Node)]
    //public DiscoveryManager DiscoveryManager { get; set; }

    //[BinaryContent(Name = "RegrowManager", NodeType = BinaryContentType.Node)]
    //public RegrowManager RegrowManager { get; set; }

    //[BinaryContent(Name = "SessionSoundManager", NodeType = BinaryContentType.Node)]
    //public SessionSoundManager SessionSoundManager { get; set; }

    //[BinaryContent(Name = "ActiveTradeManager", NodeType = BinaryContentType.Node)]
    //public ActiveTradeManager ActiveTradeManager { get; set; }

    //[BinaryContent(Name = "StreetOverlayManager", NodeType = BinaryContentType.Node)]
    //public StreetOverlayManager StreetOverlayManager { get; set; }

    //[BinaryContent(Name = "SelectionManager", NodeType = BinaryContentType.Node)]
    //public SelectionManager SelectionManager { get; set; }

    //[BinaryContent(Name = "IncidentManager", NodeType = BinaryContentType.Node)]
    //public IncidentManager IncidentManager { get; set; }

    //[BinaryContent(Name = "CameraSequenceManager", NodeType = BinaryContentType.Node)]
    //public CameraSequenceManager CameraSequenceManager { get; set; }

    //[BinaryContent(Name = "AIUnitManager", NodeType = BinaryContentType.Node)]
    //public AIUnitManager AIUnitManager { get; set; }

    //[BinaryContent(Name = "AIConstructionManager", NodeType = BinaryContentType.Node)]
    //public AIConstructionManager AIConstructionManager { get; set; }

    //[BinaryContent(Name = "AnimalManager", NodeType = BinaryContentType.Node)]
    //public AnimalManager AnimalManager { get; set; }

    //[BinaryContent(Name = "CSlotManager", NodeType = BinaryContentType.Node)]
    //public CSlotManager CSlotManager { get; set; }

    //[BinaryContent(Name = "VisitorManager", NodeType = BinaryContentType.Node)]
    //public VisitorManager VisitorManager { get; set; }

    [BinaryContent(Name = "ItemSessionManager", NodeType = BinaryContentTypes.Node)]
    public ItemSessionManager ItemSessionManager { get; set; }

    //[BinaryContent(Name = "MilitaryManager", NodeType = BinaryContentType.Node)]
    //public MilitaryManager MilitaryManager { get; set; }

    //[BinaryContent(Name = "BlueprintManager", NodeType = BinaryContentType.Node)]
    //public BlueprintManager BlueprintManager { get; set; }

    //[BinaryContent(Name = "LoadingPierManager", NodeType = BinaryContentType.Node)]
    //public LoadingPierManager LoadingPierManager { get; set; }

    //[BinaryContent(Name = "SessionFreeAreaProductivityManager", NodeType = BinaryContentType.Node)]
    //public SessionFreeAreaProductivityManager SessionFreeAreaProductivityManager { get; set; }

    //[BinaryContent(Name = "WorkforceTransferManager", NodeType = BinaryContentType.Node)]
    //public WorkforceTransferManager WorkforceTransferManager { get; set; }

    //[BinaryContent(Name = "WaterManager", NodeType = BinaryContentType.Node)]
    //public WaterManager WaterManager { get; set; }

    //[BinaryContent(Name = "CoopPingManager", NodeType = BinaryContentType.Node)]
    //public CoopPingManager CoopPingManager { get; set; }

    [BinaryContent(Name = "AreaManager", NodeType = BinaryContentTypes.Node)]
    public List<AreaManager> AreaManager { get; set; }

    [BinaryContent(Name = "AreaLinks", NodeType = BinaryContentTypes.Node)]
    public AreaLinks AreaLinks { get; set; }

    [BinaryContent(Name = "AreaInfo", NodeType = BinaryContentTypes.Node)]
    public AreaInfo AreaInfo { get; set; }

  }
}