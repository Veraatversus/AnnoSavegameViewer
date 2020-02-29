using System;
using System.Collections.Generic;
using System.Text;

namespace FileDBReader {
  /* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
  using System;
  using System.Xml.Serialization;
  using System.Collections.Generic;
  namespace Xml2CSharp {
    [XmlRoot(ElementName = "netsafeRandom")]
    public class NetsafeRandom {
      [XmlElement(ElementName = "P1")]
      public string P1 { get; set; }
      [XmlElement(ElementName = "Buffer")]
      public string Buffer { get; set; }
      [XmlElement(ElementName = "Counter")]
      public string Counter { get; set; }
    }

    [XmlRoot(ElementName = "AreaRandomManager")]
    public class AreaRandomManager {
      [XmlElement(ElementName = "netsafeRandom")]
      public NetsafeRandom NetsafeRandom { get; set; }
    }

    [XmlRoot(ElementName = "RailwayNodeGraph")]
    public class RailwayNodeGraph {
      [XmlElement(ElementName = "Nodes")]
      public string Nodes { get; set; }
      [XmlElement(ElementName = "HorizontalEdges")]
      public string HorizontalEdges { get; set; }
      [XmlElement(ElementName = "VerticalEdges")]
      public string VerticalEdges { get; set; }
    }

    [XmlRoot(ElementName = "AreaRailwayManager")]
    public class AreaRailwayManager {
      [XmlElement(ElementName = "RailwayNodeGraph")]
      public RailwayNodeGraph RailwayNodeGraph { get; set; }
    }

    [XmlRoot(ElementName = "None")]
    public class None {
      [XmlElement(ElementName = "FolderID")]
      public string FolderID { get; set; }
      [XmlElement(ElementName = "Filter")]
      public Filter Filter { get; set; }
      [XmlElement(ElementName = "GameObjects")]
      public GameObjects GameObjects { get; set; }
      [XmlElement(ElementName = "guid")]
      public string Guid { get; set; }
      [XmlElement(ElementName = "ID")]
      public string ID { get; set; }
      [XmlElement(ElementName = "Variation")]
      public string Variation { get; set; }
      [XmlElement(ElementName = "Position")]
      public string Position { get; set; }
      [XmlElement(ElementName = "Direction")]
      public string Direction { get; set; }
      [XmlElement(ElementName = "ParticipantID")]
      public ParticipantID ParticipantID { get; set; }
      [XmlElement(ElementName = "QuestObject")]
      public QuestObject QuestObject { get; set; }
      [XmlElement(ElementName = "Mesh")]
      public Mesh Mesh { get; set; }
      [XmlElement(ElementName = "SoundEmitter")]
      public string SoundEmitter { get; set; }
      [XmlElement(ElementName = "ObjectFolderID")]
      public string ObjectFolderID { get; set; }
      [XmlElement(ElementName = "Prop")]
      public Prop Prop { get; set; }
      [XmlElement(ElementName = "Blocking")]
      public string Blocking { get; set; }
      [XmlElement(ElementName = "Building")]
      public string Building { get; set; }
      [XmlElement(ElementName = "Culture")]
      public string Culture { get; set; }
      [XmlElement(ElementName = "Attackable")]
      public Attackable Attackable { get; set; }
      [XmlElement(ElementName = "Attacker")]
      public Attacker Attacker { get; set; }
      [XmlElement(ElementName = "CommandQueue")]
      public CommandQueue CommandQueue { get; set; }
      [XmlElement(ElementName = "Delayed_Construction")]
      public string Delayed_Construction { get; set; }
      [XmlElement(ElementName = "Infolayer")]
      public Infolayer Infolayer { get; set; }
      [XmlElement(ElementName = "Pausable")]
      public Pausable Pausable { get; set; }
      [XmlElement(ElementName = "Selection")]
      public Selection Selection { get; set; }
      [XmlElement(ElementName = "AmbientMoodProvider")]
      public string AmbientMoodProvider { get; set; }
      [XmlElement(ElementName = "Maintenance")]
      public string Maintenance { get; set; }
      [XmlElement(ElementName = "UpgradeList")]
      public UpgradeList UpgradeList { get; set; }
      [XmlElement(ElementName = "DistributionCenter")]
      public string DistributionCenter { get; set; }
      [XmlElement(ElementName = "LoadingPier")]
      public LoadingPier LoadingPier { get; set; }
      [XmlElement(ElementName = "FeedbackController")]
      public FeedbackController FeedbackController { get; set; }
      [XmlElement(ElementName = "Distribution")]
      public string Distribution { get; set; }
      [XmlElement(ElementName = "LogisticNode")]
      public LogisticNode LogisticNode { get; set; }
      [XmlElement(ElementName = "Warehouse")]
      public Warehouse Warehouse { get; set; }
      [XmlElement(ElementName = "value")]
      public Value Value { get; set; }
      [XmlElement(ElementName = "Incidents")]
      public string Incidents { get; set; }
      [XmlElement(ElementName = "BuildingInfectionChances")]
      public string BuildingInfectionChances { get; set; }
      [XmlElement(ElementName = "Unlocked")]
      public string Unlocked { get; set; }
    }

    [XmlRoot(ElementName = "Filter")]
    public class Filter {
      [XmlElement(ElementName = "None")]
      public None None { get; set; }
    }

    [XmlRoot(ElementName = "Root")]
    public class Root {
      [XmlElement(ElementName = "Filter")]
      public Filter Filter { get; set; }
    }

    [XmlRoot(ElementName = "ObjectGroupFilterCollection")]
    public class ObjectGroupFilterCollection {
      [XmlElement(ElementName = "Root")]
      public Root Root { get; set; }
    }

    [XmlRoot(ElementName = "GameObjects")]
    public class GameObjects {
      [XmlElement(ElementName = "None")]
      public List<string> None { get; set; }
    }

    [XmlRoot(ElementName = "ObjectGroups")]
    public class ObjectGroups {
      [XmlElement(ElementName = "None")]
      public List<None> None { get; set; }
    }

    [XmlRoot(ElementName = "ObjectGroupCollection")]
    public class ObjectGroupCollection {
      [XmlElement(ElementName = "ObjectGroups")]
      public ObjectGroups ObjectGroups { get; set; }
    }

    [XmlRoot(ElementName = "ParticipantID")]
    public class ParticipantID {
      [XmlElement(ElementName = "id")]
      public string Id { get; set; }
    }

    [XmlRoot(ElementName = "ObjectWasVisible")]
    public class ObjectWasVisible {
      [XmlElement(ElementName = "None")]
      public List<string> None { get; set; }
    }

    [XmlRoot(ElementName = "QuestObject")]
    public class QuestObject {
      [XmlElement(ElementName = "ObjectWasVisible")]
      public ObjectWasVisible ObjectWasVisible { get; set; }
      [XmlElement(ElementName = "OverwriteVisualParticipant")]
      public string OverwriteVisualParticipant { get; set; }
      [XmlElement(ElementName = "QuestIDs")]
      public QuestIDs QuestIDs { get; set; }
    }

    [XmlRoot(ElementName = "Flags")]
    public class Flags {
      [XmlElement(ElementName = "flags")]
      public string Flags { get; set; }
    }

    [XmlRoot(ElementName = "SequenceData")]
    public class SequenceData {
      [XmlElement(ElementName = "CurrentSequenceStartTime")]
      public string CurrentSequenceStartTime { get; set; }
      [XmlElement(ElementName = "CurrentSequenceID")]
      public string CurrentSequenceID { get; set; }
      [XmlElement(ElementName = "IdleSequenceID")]
      public string IdleSequenceID { get; set; }
    }

    [XmlRoot(ElementName = "Mesh")]
    public class Mesh {
      [XmlElement(ElementName = "Flags")]
      public Flags Flags { get; set; }
      [XmlElement(ElementName = "DyeColorDetail")]
      public string DyeColorDetail { get; set; }
      [XmlElement(ElementName = "SequenceData")]
      public SequenceData SequenceData { get; set; }
      [XmlElement(ElementName = "Orientation")]
      public string Orientation { get; set; }
      [XmlElement(ElementName = "Scale")]
      public string Scale { get; set; }
    }

    [XmlRoot(ElementName = "Prop")]
    public class Prop {
      [XmlElement(ElementName = "Position")]
      public string Position { get; set; }
      [XmlElement(ElementName = "Rotation")]
      public string Rotation { get; set; }
      [XmlElement(ElementName = "Scale")]
      public string Scale { get; set; }
      [XmlElement(ElementName = "Color")]
      public string Color { get; set; }
    }

    [XmlRoot(ElementName = "Attackable")]
    public class Attackable {
      [XmlElement(ElementName = "LastAttackerID")]
      public string LastAttackerID { get; set; }
      [XmlElement(ElementName = "IslandWarFlagID")]
      public string IslandWarFlagID { get; set; }
      [XmlElement(ElementName = "ExplosionCheckThreshold")]
      public string ExplosionCheckThreshold { get; set; }
      [XmlElement(ElementName = "LastDamageTime")]
      public string LastDamageTime { get; set; }
      [XmlElement(ElementName = "LastDamageByAttacker")]
      public string LastDamageByAttacker { get; set; }
      [XmlElement(ElementName = "HealTickRemainder")]
      public string HealTickRemainder { get; set; }
      [XmlElement(ElementName = "LastDamageOwner")]
      public string LastDamageOwner { get; set; }
      [XmlElement(ElementName = "LastOvertakeDamageDealerOwner")]
      public string LastOvertakeDamageDealerOwner { get; set; }
      [XmlElement(ElementName = "StatusEffects")]
      public string StatusEffects { get; set; }
      [XmlElement(ElementName = "ManagedAttackersByRange")]
      public string ManagedAttackersByRange { get; set; }
    }

    [XmlRoot(ElementName = "Turrets")]
    public class Turrets {
      [XmlElement(ElementName = "count")]
      public string Count { get; set; }
      [XmlElement(ElementName = "CanFireAtTarget")]
      public string CanFireAtTarget { get; set; }
    }

    [XmlRoot(ElementName = "Attacker")]
    public class Attacker {
      [XmlElement(ElementName = "Turrets")]
      public Turrets Turrets { get; set; }
      [XmlElement(ElementName = "AutoAttackID")]
      public string AutoAttackID { get; set; }
      [XmlElement(ElementName = "FirePerSide")]
      public string FirePerSide { get; set; }
      [XmlElement(ElementName = "FutureBorrowedShots")]
      public string FutureBorrowedShots { get; set; }
      [XmlElement(ElementName = "ProjectileLaunchinformation")]
      public string ProjectileLaunchinformation { get; set; }
      [XmlElement(ElementName = "IsBlinded")]
      public string IsBlinded { get; set; }
    }

    [XmlRoot(ElementName = "Object")]
    public class Object {
      [XmlElement(ElementName = "ObjectID")]
      public string ObjectID { get; set; }
    }

    [XmlRoot(ElementName = "AttachObject")]
    public class AttachObject {
      [XmlElement(ElementName = "ObjectID")]
      public string ObjectID { get; set; }
    }

    [XmlRoot(ElementName = "OptimalAttackMovementData")]
    public class OptimalAttackMovementData {
      [XmlElement(ElementName = "OptimalAngleWS")]
      public string OptimalAngleWS { get; set; }
      [XmlElement(ElementName = "OptimalDistanceWS")]
      public string OptimalDistanceWS { get; set; }
    }

    [XmlRoot(ElementName = "StateParams")]
    public class StateParams {
      [XmlElement(ElementName = "Radius")]
      public string Radius { get; set; }
      [XmlElement(ElementName = "Object")]
      public Object Object { get; set; }
      [XmlElement(ElementName = "AttachRadius")]
      public string AttachRadius { get; set; }
      [XmlElement(ElementName = "AttachObject")]
      public AttachObject AttachObject { get; set; }
      [XmlElement(ElementName = "EscortedObjectMetaID")]
      public string EscortedObjectMetaID { get; set; }
      [XmlElement(ElementName = "StateOnQuitPassiveAttack")]
      public string StateOnQuitPassiveAttack { get; set; }
      [XmlElement(ElementName = "OptimalAttackMovementData")]
      public OptimalAttackMovementData OptimalAttackMovementData { get; set; }
    }

    [XmlRoot(ElementName = "CommandQueue")]
    public class CommandQueue {
      [XmlElement(ElementName = "Commands")]
      public string Commands { get; set; }
      [XmlElement(ElementName = "BasePosition")]
      public string BasePosition { get; set; }
      [XmlElement(ElementName = "BaseRotation")]
      public string BaseRotation { get; set; }
      [XmlElement(ElementName = "SpecialAssignment")]
      public string SpecialAssignment { get; set; }
      [XmlElement(ElementName = "StateParams")]
      public StateParams StateParams { get; set; }
    }

    [XmlRoot(ElementName = "Infolayer")]
    public class Infolayer {
      [XmlElement(ElementName = "Icons")]
      public Icons Icons { get; set; }
    }

    [XmlRoot(ElementName = "Pausable")]
    public class Pausable {
      [XmlElement(ElementName = "PausedReasons")]
      public string PausedReasons { get; set; }
    }

    [XmlRoot(ElementName = "Selection")]
    public class Selection {
      [XmlElement(ElementName = "Detected")]
      public string Detected { get; set; }
    }

    [XmlRoot(ElementName = "UpgradeList")]
    public class UpgradeList {
      [XmlElement(ElementName = "UpgradeGUIDs")]
      public string UpgradeGUIDs { get; set; }
      [XmlElement(ElementName = "UpgradeSets")]
      public string UpgradeSets { get; set; }
      [XmlElement(ElementName = "ElectricityUpgrades")]
      public string ElectricityUpgrades { get; set; }
      [XmlElement(ElementName = "HasElectricity")]
      public string HasElectricity { get; set; }
    }

    [XmlRoot(ElementName = "QuestIDs")]
    public class QuestIDs {
      [XmlElement(ElementName = "None")]
      public string None { get; set; }
    }

    [XmlRoot(ElementName = "Icons")]
    public class Icons {
      [XmlElement(ElementName = "None")]
      public None None { get; set; }
    }

    [XmlRoot(ElementName = "CurrentTradePartnerArray")]
    public class CurrentTradePartnerArray {
      [XmlElement(ElementName = "None")]
      public List<None> None { get; set; }
    }

    [XmlRoot(ElementName = "LoadingPier")]
    public class LoadingPier {
      [XmlElement(ElementName = "LoadingHarbourID")]
      public string LoadingHarbourID { get; set; }
      [XmlElement(ElementName = "CurrentTradePartnerArray")]
      public CurrentTradePartnerArray CurrentTradePartnerArray { get; set; }
    }

    [XmlRoot(ElementName = "FeedbackController")]
    public class FeedbackController {
      [XmlElement(ElementName = "OverrideSequence")]
      public string OverrideSequence { get; set; }
      [XmlElement(ElementName = "SequenceStartTime")]
      public string SequenceStartTime { get; set; }
    }

    [XmlRoot(ElementName = "TransporterQueue")]
    public class TransporterQueue {
      [XmlElement(ElementName = "QueuedTransporters")]
      public string QueuedTransporters { get; set; }
      [XmlElement(ElementName = "ProcessingTransporters")]
      public string ProcessingTransporters { get; set; }
    }

    [XmlRoot(ElementName = "LogisticNode")]
    public class LogisticNode {
      [XmlElement(ElementName = "Storage")]
      public string Storage { get; set; }
      [XmlElement(ElementName = "Transporters")]
      public string Transporters { get; set; }
      [XmlElement(ElementName = "TransporterQueue")]
      public TransporterQueue TransporterQueue { get; set; }
    }

    [XmlRoot(ElementName = "Warehouse")]
    public class Warehouse {
      [XmlElement(ElementName = "StorageCapacityRegistered")]
      public string StorageCapacityRegistered { get; set; }
      [XmlElement(ElementName = "LockedStorage")]
      public string LockedStorage { get; set; }
    }

    [XmlRoot(ElementName = "objects")]
    public class Objects {
      [XmlElement(ElementName = "None")]
      public List<None> None { get; set; }
    }

    [XmlRoot(ElementName = "GameObject")]
    public class GameObject {
      [XmlElement(ElementName = "objects")]
      public Objects Objects { get; set; }
    }

    [XmlRoot(ElementName = "Nature")]
    public class Nature {
      [XmlElement(ElementName = "objects")]
      public string Objects { get; set; }
    }

    [XmlRoot(ElementName = "AreaObjectManager")]
    public class AreaObjectManager {
      [XmlElement(ElementName = "GameObjectIDCounter")]
      public string GameObjectIDCounter { get; set; }
      [XmlElement(ElementName = "NonGameObjectIDCounter")]
      public string NonGameObjectIDCounter { get; set; }
      [XmlElement(ElementName = "QueuedChangeGUID")]
      public string QueuedChangeGUID { get; set; }
      [XmlElement(ElementName = "QueuedDeletes")]
      public string QueuedDeletes { get; set; }
      [XmlElement(ElementName = "ObjectGroupFilterCollection")]
      public ObjectGroupFilterCollection ObjectGroupFilterCollection { get; set; }
      [XmlElement(ElementName = "ObjectGroupCollection")]
      public ObjectGroupCollection ObjectGroupCollection { get; set; }
      [XmlElement(ElementName = "GameObject")]
      public GameObject GameObject { get; set; }
      [XmlElement(ElementName = "Nature")]
      public Nature Nature { get; set; }
    }

    [XmlRoot(ElementName = "AreaResidenceConsumptionManager")]
    public class AreaResidenceConsumptionManager {
      [XmlElement(ElementName = "ProductDistributionMap")]
      public string ProductDistributionMap { get; set; }
    }

    [XmlRoot(ElementName = "value")]
    public class Value {
      [XmlElement(ElementName = "id")]
      public string Id { get; set; }
    }

    [XmlRoot(ElementName = "CitySize")]
    public class CitySize {
      [XmlElement(ElementName = "value")]
      public Value Value { get; set; }
    }

    [XmlRoot(ElementName = "AreaPopulationManager")]
    public class AreaPopulationManager {
      [XmlElement(ElementName = "CitySize")]
      public CitySize CitySize { get; set; }
    }

    [XmlRoot(ElementName = "AreaTransporterManager")]
    public class AreaTransporterManager {
      [XmlElement(ElementName = "Transporters")]
      public string Transporters { get; set; }
      [XmlElement(ElementName = "UnsentTransporters")]
      public string UnsentTransporters { get; set; }
    }

    [XmlRoot(ElementName = "AreaAttractivityManager")]
    public class AreaAttractivityManager {
      [XmlElement(ElementName = "CurCityStatus")]
      public string CurCityStatus { get; set; }
      [XmlElement(ElementName = "BaseNatureAttractiveness")]
      public string BaseNatureAttractiveness { get; set; }
      [XmlElement(ElementName = "TriggeredBanners")]
      public string TriggeredBanners { get; set; }
    }

    [XmlRoot(ElementName = "AreaSlotContainer")]
    public class AreaSlotContainer {
      [XmlElement(ElementName = "SlotList")]
      public string SlotList { get; set; }
      [XmlElement(ElementName = "UnlimitedSlotCount")]
      public string UnlimitedSlotCount { get; set; }
      [XmlElement(ElementName = "UnlimitedStack")]
      public string UnlimitedStack { get; set; }
      [XmlElement(ElementName = "AreaID")]
      public string AreaID { get; set; }
    }

    [XmlRoot(ElementName = "AreaItemManager")]
    public class AreaItemManager {
      [XmlElement(ElementName = "AreaSlotContainer")]
      public AreaSlotContainer AreaSlotContainer { get; set; }
    }

    [XmlRoot(ElementName = "AreaIncidentManager")]
    public class AreaIncidentManager {
      [XmlElement(ElementName = "incidentTypeData")]
      public IncidentTypeData IncidentTypeData { get; set; }
    }

    [XmlRoot(ElementName = "owner")]
    public class Owner {
      [XmlElement(ElementName = "value")]
      public Value Value { get; set; }
    }

    [XmlRoot(ElementName = "HappinessData")]
    public class HappinessData {
      [XmlElement(ElementName = "owner")]
      public Owner Owner { get; set; }
      [XmlElement(ElementName = "areaID")]
      public string AreaID { get; set; }
      [XmlElement(ElementName = "avgHappiness")]
      public string AvgHappiness { get; set; }
      [XmlElement(ElementName = "pollution")]
      public string Pollution { get; set; }
      [XmlElement(ElementName = "warfare")]
      public string Warfare { get; set; }
      [XmlElement(ElementName = "workingConditions")]
      public string WorkingConditions { get; set; }
    }

    [XmlRoot(ElementName = "AreaHappinessManager")]
    public class AreaHappinessManager {
      [XmlElement(ElementName = "HappinessData")]
      public HappinessData HappinessData { get; set; }
    }

    [XmlRoot(ElementName = "incidentTypeData")]
    public class IncidentTypeData {
      [XmlElement(ElementName = "None")]
      public List<None> None { get; set; }
    }

    [XmlRoot(ElementName = "AreaFestivalManager")]
    public class AreaFestivalManager {
      [XmlElement(ElementName = "nextTick")]
      public string NextTick { get; set; }
      [XmlElement(ElementName = "poolThreshold")]
      public string PoolThreshold { get; set; }
      [XmlElement(ElementName = "activeType")]
      public string ActiveType { get; set; }
      [XmlElement(ElementName = "activeEffects")]
      public string ActiveEffects { get; set; }
    }

    [XmlRoot(ElementName = "AreaHarbourPropManager")]
    public class AreaHarbourPropManager {
      [XmlElement(ElementName = "TileToPropIDs")]
      public string TileToPropIDs { get; set; }
    }

    [XmlRoot(ElementName = "AreaManager")]
    public class AreaManager {
      [XmlElement(ElementName = "AreaRandomManager")]
      public AreaRandomManager AreaRandomManager { get; set; }
      [XmlElement(ElementName = "AreaRailwayManager")]
      public AreaRailwayManager AreaRailwayManager { get; set; }
      [XmlElement(ElementName = "AreaObjectManager")]
      public AreaObjectManager AreaObjectManager { get; set; }
      [XmlElement(ElementName = "AreaResidenceConsumptionManager")]
      public AreaResidenceConsumptionManager AreaResidenceConsumptionManager { get; set; }
      [XmlElement(ElementName = "AreaPopulationManager")]
      public AreaPopulationManager AreaPopulationManager { get; set; }
      [XmlElement(ElementName = "AreaTransporterManager")]
      public AreaTransporterManager AreaTransporterManager { get; set; }
      [XmlElement(ElementName = "AreaElectricity")]
      public string AreaElectricity { get; set; }
      [XmlElement(ElementName = "AreaAttractivityManager")]
      public AreaAttractivityManager AreaAttractivityManager { get; set; }
      [XmlElement(ElementName = "AreaItemManager")]
      public AreaItemManager AreaItemManager { get; set; }
      [XmlElement(ElementName = "AreaIncidentManager")]
      public List<AreaIncidentManager> AreaIncidentManager { get; set; }
      [XmlElement(ElementName = "AreaHappinessManager")]
      public AreaHappinessManager AreaHappinessManager { get; set; }
      [XmlElement(ElementName = "AreaFestivalManager")]
      public AreaFestivalManager AreaFestivalManager { get; set; }
      [XmlElement(ElementName = "AreaHarbourPropManager")]
      public AreaHarbourPropManager AreaHarbourPropManager { get; set; }
      [XmlElement(ElementName = "AreaSaturationTrackerManager")]
      public string AreaSaturationTrackerManager { get; set; }
    }

  }

}
