using AnnoSavegameViewer.Serialization.Core;
using System.Diagnostics;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  [DebuggerDisplay("{Guid.GUID}, {Guid}")]
  public class GameObjectObjectsList {

    #region Public Properties

    [BinaryContent(Name = "guid", NodeType = BinaryContentTypes.Attribute)]
    public DescriptionInt Guid { get; set; }

    [BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
    public long ID { get; set; }

    [BinaryContent(Name = "Variation", NodeType = BinaryContentTypes.Attribute)]
    public int Variation { get; set; }

    [BinaryContent(Name = "Position", NodeType = BinaryContentTypes.Attribute)]
    public object Position { get; set; }

    [BinaryContent(Name = "Direction", NodeType = BinaryContentTypes.Attribute)]
    public object Direction { get; set; }

    [BinaryContent(Name = "ObjectFolderID", NodeType = BinaryContentTypes.Attribute)]
    public object ObjectFolderID { get; set; }

    [BinaryContent(Name = "StateBits", NodeType = BinaryContentTypes.Attribute)]
    public object StateBits { get; set; }

    [BinaryContent(Name = "ParticipantID", NodeType = BinaryContentTypes.Node)]
    public GameObjectObjectsListParticipantID ParticipantID { get; set; }

    [BinaryContent(Name = "QuestObject", NodeType = BinaryContentTypes.Node)]
    public QuestObject QuestObject { get; set; }

    [BinaryContent(Name = "Mesh", NodeType = BinaryContentTypes.Node)]
    public Mesh Mesh { get; set; }

    [BinaryContent(Name = "SoundEmitter", NodeType = BinaryContentTypes.Node)]
    public SoundEmitter SoundEmitter { get; set; }

    [BinaryContent(Name = "Attackable", NodeType = BinaryContentTypes.Node)]
    public Attackable Attackable { get; set; }

    [BinaryContent(Name = "Collector", NodeType = BinaryContentTypes.Node)]
    public Collector Collector { get; set; }

    [BinaryContent(Name = "CommandQueue", NodeType = BinaryContentTypes.Node)]
    public CommandQueue CommandQueue { get; set; }

    [BinaryContent(Name = "Draggable", NodeType = BinaryContentTypes.Node)]
    public Draggable Draggable { get; set; }

    [BinaryContent(Name = "FeedbackController", NodeType = BinaryContentTypes.Node)]
    public FeedbackController FeedbackController { get; set; }

    [BinaryContent(Name = "Infolayer", NodeType = BinaryContentTypes.Node)]
    public Infolayer Infolayer { get; set; }

    [BinaryContent(Name = "MetaPersistent", NodeType = BinaryContentTypes.Node)]
    public MetaPersistent MetaPersistent { get; set; }

    [BinaryContent(Name = "Nameable", NodeType = BinaryContentTypes.Node)]
    public Nameable Nameable { get; set; }

    [BinaryContent(Name = "Pausable", NodeType = BinaryContentTypes.Node)]
    public Pausable Pausable { get; set; }

    [BinaryContent(Name = "Rentable", NodeType = BinaryContentTypes.Node)]
    public Rentable Rentable { get; set; }

    [BinaryContent(Name = "Selection", NodeType = BinaryContentTypes.Node)]
    public Selection Selection { get; set; }

    [BinaryContent(Name = "Sellable", NodeType = BinaryContentTypes.Node)]
    public Sellable Sellable { get; set; }

    [BinaryContent(Name = "ShipIncident", NodeType = BinaryContentTypes.Node)]
    public ShipIncident ShipIncident { get; set; }

    [BinaryContent(Name = "ShipMaintenance", NodeType = BinaryContentTypes.Node)]
    public ShipMaintenance ShipMaintenance { get; set; }

    [BinaryContent(Name = "PropertyTradeRouteVehicle", NodeType = BinaryContentTypes.Node)]
    public PropertyTradeRouteVehicle PropertyTradeRouteVehicle { get; set; }

    [BinaryContent(Name = "Walking", NodeType = BinaryContentTypes.Node)]
    public Walking Walking { get; set; }

    [BinaryContent(Name = "ItemContainer", NodeType = BinaryContentTypes.Node)]
    public ItemContainer ItemContainer { get; set; }

    [BinaryContent(Name = "UpgradeList", NodeType = BinaryContentTypes.Node)]
    public UpgradeList UpgradeList { get; set; }

    [BinaryContent(Name = "ItemCrafter", NodeType = BinaryContentTypes.Node)]
    public ItemCrafter ItemCrafter { get; set; }

    [BinaryContent(Name = "ThirdParty", NodeType = BinaryContentTypes.Node)]
    public ThirdParty ThirdParty { get; set; }

    [BinaryContent(Name = "Trader", NodeType = BinaryContentTypes.Node)]
    public Trader Trader { get; set; }

    [BinaryContent(Name = "Diplomacy", NodeType = BinaryContentTypes.Node)]
    public Diplomacy Diplomacy { get; set; }

    [BinaryContent(Name = "Profile", NodeType = BinaryContentTypes.Node)]
    public Profile Profile { get; set; }

    [BinaryContent(Name = "ConstructionAI", NodeType = BinaryContentTypes.Node)]
    public ConstructionAI ConstructionAI { get; set; }

    [BinaryContent(Name = "MilitaryAI", NodeType = BinaryContentTypes.Node)]
    public MilitaryAI MilitaryAI { get; set; }

    [BinaryContent(Name = "DivingBell", NodeType = BinaryContentTypes.Node)]
    public DivingBell DivingBell { get; set; }

    [BinaryContent(Name = "Collectable", NodeType = BinaryContentTypes.Node)]
    public Collectable Collectable { get; set; }

    [BinaryContent(Name = "Lifetime", NodeType = BinaryContentTypes.Node)]
    public Lifetime Lifetime { get; set; }

    [BinaryContent(Name = "AmbientMoodProvider", NodeType = BinaryContentTypes.Node)]
    public AmbientMoodProvider AmbientMoodProvider { get; set; }

    [BinaryContent(Name = "FishShoal", NodeType = BinaryContentTypes.Node)]
    public FishShoal FishShoal { get; set; }

    [BinaryContent(Name = "Prop", NodeType = BinaryContentTypes.Node)]
    public Prop Prop { get; set; }

    [BinaryContent(Name = "Blocking", NodeType = BinaryContentTypes.Node)]
    public Blocking Blocking { get; set; }

    [BinaryContent(Name = "Building", NodeType = BinaryContentTypes.Node)]
    public Building Building { get; set; }

    [BinaryContent(Name = "ItemCrafterBuilding", NodeType = BinaryContentTypes.Node)]
    public ItemCrafterBuilding ItemCrafterBuilding { get; set; }

    [BinaryContent(Name = "DivingBellObject", NodeType = BinaryContentTypes.Node)]
    public DivingBellObject DivingBellObject { get; set; }

    [BinaryContent(Name = "WorkAreaPath", NodeType = BinaryContentTypes.Node)]
    public WorkAreaPath WorkAreaPath { get; set; }

    [BinaryContent(Name = "Culture", NodeType = BinaryContentTypes.Node)]
    public Culture Culture { get; set; }

    [BinaryContent(Name = "Delayed Construction", NodeType = BinaryContentTypes.Node)]
    public Delayed_Construction Delayed_Construction { get; set; }

    [BinaryContent(Name = "Maintenance", NodeType = BinaryContentTypes.Node)]
    public Maintenance Maintenance { get; set; }

    [BinaryContent(Name = "IncidentInfluencer", NodeType = BinaryContentTypes.Node)]
    public IncidentInfluencer IncidentInfluencer { get; set; }

    [BinaryContent(Name = "IncidentResolver", NodeType = BinaryContentTypes.Node)]
    public IncidentResolver IncidentResolver { get; set; }

    [BinaryContent(Name = "Heated", NodeType = BinaryContentTypes.Node)]
    public Heated Heated { get; set; }

    [BinaryContent(Name = "LogisticNode", NodeType = BinaryContentTypes.Node)]
    public LogisticNode LogisticNode { get; set; }

    [BinaryContent(Name = "Electric", NodeType = BinaryContentTypes.Node)]
    public Electric Electric { get; set; }

    [BinaryContent(Name = "PublicService", NodeType = BinaryContentTypes.Node)]
    public PublicService PublicService { get; set; }

    [BinaryContent(Name = "IncidentInfectable", NodeType = BinaryContentTypes.Node)]
    public IncidentInfectable IncidentInfectable { get; set; }

    [BinaryContent(Name = "StreetActivation", NodeType = BinaryContentTypes.Node)]
    public StreetActivation StreetActivation { get; set; }

    [BinaryContent(Name = "PropertyRandomDummySpawner", NodeType = BinaryContentTypes.Node)]
    public PropertyRandomDummySpawner PropertyRandomDummySpawner { get; set; }

    [BinaryContent(Name = "Residence7", NodeType = BinaryContentTypes.Node)]
    public Residence7 Residence7 { get; set; }

    [BinaryContent(Name = "RandomMapObject", NodeType = BinaryContentTypes.Node)]
    public RandomMapObject RandomMapObject { get; set; }

    [BinaryContent(Name = "HeatProvider", NodeType = BinaryContentTypes.Node)]
    public HeatProvider HeatProvider { get; set; }

    [BinaryContent(Name = "BuildingModule", NodeType = BinaryContentTypes.Node)]
    public BuildingModule BuildingModule { get; set; }

    [BinaryContent(Name = "DistributionCenter", NodeType = BinaryContentTypes.Node)]
    public DistributionCenter DistributionCenter { get; set; }

    [BinaryContent(Name = "LoadingPier", NodeType = BinaryContentTypes.Node)]
    public LoadingPier LoadingPier { get; set; }

    [BinaryContent(Name = "Attacker", NodeType = BinaryContentTypes.Node)]
    public Attacker Attacker { get; set; }

    [BinaryContent(Name = "Distribution", NodeType = BinaryContentTypes.Node)]
    public Distribution Distribution { get; set; }

    [BinaryContent(Name = "Warehouse", NodeType = BinaryContentTypes.Node)]
    public Warehouse Warehouse { get; set; }

    [BinaryContent(Name = "Market", NodeType = BinaryContentTypes.Node)]
    public Market Market { get; set; }

    [BinaryContent(Name = "Monument", NodeType = BinaryContentTypes.Node)]
    public Monument Monument { get; set; }

    [BinaryContent(Name = "Shipyard", NodeType = BinaryContentTypes.Node)]
    public Shipyard Shipyard { get; set; }

    [BinaryContent(Name = "ModuleOwner", NodeType = BinaryContentTypes.Node)]
    public ModuleOwner ModuleOwner { get; set; }

    [BinaryContent(Name = "Factory7", NodeType = BinaryContentTypes.Node)]
    public Factory7 Factory7 { get; set; }

    [BinaryContent(Name = "BezierPath", NodeType = BinaryContentTypes.Node)]
    public BezierPath BezierPath { get; set; }

    [BinaryContent(Name = "FreeAreaproductivity", NodeType = BinaryContentTypes.Node)]
    public FreeAreaproductivity FreeAreaproductivity { get; set; }

    [BinaryContent(Name = "Projectile", NodeType = BinaryContentTypes.Node)]
    public Projectile Projectile { get; set; }

    [BinaryContent(Name = "SeaMine", NodeType = BinaryContentTypes.Node)]
    public SeaMine SeaMine { get; set; }

    [BinaryContent(Name = "DynamicVariation", NodeType = BinaryContentTypes.Node)]
    public DynamicVariation DynamicVariation { get; set; }

    [BinaryContent(Name = "Bridge", NodeType = BinaryContentTypes.Node)]
    public Bridge Bridge { get; set; }

    [BinaryContent(Name = "Powerplant", NodeType = BinaryContentTypes.Node)]
    public Powerplant Powerplant { get; set; }

    [BinaryContent(Name = "RepairCrane", NodeType = BinaryContentTypes.Node)]
    public RepairCrane RepairCrane { get; set; }

    [BinaryContent(Name = "WorkforceConnector", NodeType = BinaryContentTypes.Node)]
    public WorkforceConnector WorkforceConnector { get; set; }

    [BinaryContent(Name = "VisitorHarbor", NodeType = BinaryContentTypes.Node)]
    public VisitorHarbor VisitorHarbor { get; set; }

    [BinaryContent(Name = "TrainStation", NodeType = BinaryContentTypes.Node)]
    public TrainStation TrainStation { get; set; }

    [BinaryContent(Name = "Pirate", NodeType = BinaryContentTypes.Node)]
    public Pirate Pirate { get; set; }

    [BinaryContent(Name = "LinkedObject", NodeType = BinaryContentTypes.Node)]
    public LinkedObject LinkedObject { get; set; }

    #endregion Public Properties
  }
}