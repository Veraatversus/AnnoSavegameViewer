namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ConstructionAI {

    #region Public Properties

    [BinaryContent(Name = "SessionGUID", NodeType = BinaryContentTypes.Attribute)]
    public object SessionGUID { get; set; }

    [BinaryContent(Name = "NextCityBlockID", NodeType = BinaryContentTypes.Attribute)]
    public object NextCityBlockID { get; set; }

    [BinaryContent(Name = "NextProductionBlockID", NodeType = BinaryContentTypes.Attribute)]
    public object NextProductionBlockID { get; set; }

    [BinaryContent(Name = "AITIme", NodeType = BinaryContentTypes.Attribute)]
    public object AITIme { get; set; }

    [BinaryContent(Name = "NextObjectID", NodeType = BinaryContentTypes.Attribute)]
    public object NextObjectID { get; set; }

    [BinaryContent(Name = "SessionRole", NodeType = BinaryContentTypes.Attribute)]
    public object SessionRole { get; set; }

    [BinaryContent(Name = "NotifiedPeers", NodeType = BinaryContentTypes.Attribute)]
    public object NotifiedPeers { get; set; }

    [BinaryContent(Name = "MainIsland", NodeType = BinaryContentTypes.Attribute)]
    public object MainIsland { get; set; }

    [BinaryContent(Name = "NextCulturalBlockID", NodeType = BinaryContentTypes.Attribute)]
    public object NextCulturalBlockID { get; set; }

    [BinaryContent(Name = "Job", NodeType = BinaryContentTypes.Node)]
    public Job Job { get; set; }

    [BinaryContent(Name = "Region", NodeType = BinaryContentTypes.Node)]
    public ConstructionAIRegion Region { get; set; }

    [BinaryContent(Name = "SpecialBuildings", NodeType = BinaryContentTypes.Node)]
    public SpecialBuildings SpecialBuildings { get; set; }

    [BinaryContent(Name = "ActiveTradeHandler", NodeType = BinaryContentTypes.Node)]
    public ActiveTradeHandler ActiveTradeHandler { get; set; }

    [BinaryContent(Name = "GoodTransferHandler", NodeType = BinaryContentTypes.Node)]
    public GoodTransferHandler GoodTransferHandler { get; set; }

    [BinaryContent(Name = "OptimizeTasks", NodeType = BinaryContentTypes.Node)]
    public OptimizeTasks OptimizeTasks { get; set; }

    [BinaryContent(Name = "VehicleConstruction", NodeType = BinaryContentTypes.Node)]
    public VehicleConstruction VehicleConstruction { get; set; }

    [BinaryContent(Name = "GlobalBalance", NodeType = BinaryContentTypes.Node)]
    public GlobalBalance GlobalBalance { get; set; }

    [BinaryContent(Name = "ConstructionQueue", NodeType = BinaryContentTypes.Node)]
    public ConstructionQueue ConstructionQueue { get; set; }

    [BinaryContent(Name = "Settlement", NodeType = BinaryContentTypes.Node)]
    public Settlement Settlement { get; set; }

    [BinaryContent(Name = "BuildabilityCache", NodeType = BinaryContentTypes.Node)]
    public BuildabilityCache BuildabilityCache { get; set; }

    [BinaryContent(Name = "TradeRoute", NodeType = BinaryContentTypes.Node)]
    public TradeRoute TradeRoute { get; set; }

    [BinaryContent(Name = "Random", NodeType = BinaryContentTypes.Node)]
    public Random Random { get; set; }

    [BinaryContent(Name = "ParentParticipantID", NodeType = BinaryContentTypes.Node)]
    public ParentParticipantID ParentParticipantID { get; set; }

    [BinaryContent(Name = "FinalizeStreets", NodeType = BinaryContentTypes.Node)]
    public FinalizeStreets FinalizeStreets { get; set; }

    [BinaryContent(Name = "FinalizeBuildings", NodeType = BinaryContentTypes.Node)]
    public FinalizeBuildings FinalizeBuildings { get; set; }

    [BinaryContent(Name = "FinalizeBridges", NodeType = BinaryContentTypes.Node)]
    public FinalizeBridges FinalizeBridges { get; set; }

    [BinaryContent(Name = "ExpectedStreetChanges", NodeType = BinaryContentTypes.Node)]
    public ExpectedStreetChanges ExpectedStreetChanges { get; set; }

    [BinaryContent(Name = "ExpectedObjectChanges", NodeType = BinaryContentTypes.Node)]
    public ExpectedObjectChanges ExpectedObjectChanges { get; set; }

    [BinaryContent(Name = "ExpectedBridgeChanges", NodeType = BinaryContentTypes.Node)]
    public ExpectedBridgeChanges ExpectedBridgeChanges { get; set; }

    [BinaryContent(Name = "BuildingsToModules", NodeType = BinaryContentTypes.Node)]
    public BuildingsToModules BuildingsToModules { get; set; }

    [BinaryContent(Name = "ModulesToParent", NodeType = BinaryContentTypes.Node)]
    public ModulesToParent ModulesToParent { get; set; }

    [BinaryContent(Name = "ObjectIDMap", NodeType = BinaryContentTypes.Node)]
    public ObjectIDMap ObjectIDMap { get; set; }

    [BinaryContent(Name = "ReceivedPermissionInfo", NodeType = BinaryContentTypes.Node)]
    public ReceivedPermissionInfo ReceivedPermissionInfo { get; set; }

    [BinaryContent(Name = "EventBuffer", NodeType = BinaryContentTypes.Node)]
    public EventBuffer EventBuffer { get; set; }

    [BinaryContent(Name = "DataBuffer", NodeType = BinaryContentTypes.Node)]
    public DataBuffer DataBuffer { get; set; }

    [BinaryContent(Name = "ItemTrade", NodeType = BinaryContentTypes.Node)]
    public ItemTrade ItemTrade { get; set; }

    [BinaryContent(Name = "Seamines", NodeType = BinaryContentTypes.Node)]
    public Seamines Seamines { get; set; }

    #endregion Public Properties
  }
}