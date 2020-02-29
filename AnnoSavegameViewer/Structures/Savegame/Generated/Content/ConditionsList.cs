using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ConditionsList {

    #region Public Properties

    [BinaryContent(Name = "ConditionKey", NodeType = BinaryContentTypes.Attribute)]
    public object ConditionKey { get; set; }

    [BinaryContent(Name = "Context", NodeType = BinaryContentTypes.Attribute)]
    public object Context { get; set; }

    [BinaryContent(Name = "CounterAmount", NodeType = BinaryContentTypes.Attribute)]
    public object CounterAmount { get; set; }

    [BinaryContent(Name = "CounterScopeContext", NodeType = BinaryContentTypes.Attribute)]
    public object CounterScopeContext { get; set; }

    [BinaryContent(Name = "CheckSpecificParticipant", NodeType = BinaryContentTypes.Attribute)]
    public object CheckSpecificParticipant { get; set; }

    [BinaryContent(Name = "StartingAmount", NodeType = BinaryContentTypes.Attribute)]
    public object StartingAmount { get; set; }

    [BinaryContent(Name = "UniqueID", NodeType = BinaryContentTypes.Attribute)]
    public object UniqueID { get; set; }

    [BinaryContent(Name = "IsResolved", NodeType = BinaryContentTypes.Attribute)]
    public object IsResolved { get; set; }

    [BinaryContent(Name = "AssetGUID", NodeType = BinaryContentTypes.Attribute)]
    public object AssetGUID { get; set; }

    [BinaryContent(Name = "IsPermanent", NodeType = BinaryContentTypes.Attribute)]
    public object IsPermanent { get; set; }

    [BinaryContent(Name = "UpdateManually", NodeType = BinaryContentTypes.Attribute)]
    public object UpdateManually { get; set; }

    [BinaryContent(Name = "Trigger", NodeType = BinaryContentTypes.Attribute)]
    public object Trigger { get; set; }

    [BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
    public List<object> AreaID { get; set; }

    [BinaryContent(Name = "IsActive", NodeType = BinaryContentTypes.Attribute)]
    public object IsActive { get; set; }

    [BinaryContent(Name = "UnlockNeeded", NodeType = BinaryContentTypes.Attribute)]
    public object UnlockNeeded { get; set; }

    [BinaryContent(Name = "TimeLimit", NodeType = BinaryContentTypes.Attribute)]
    public object TimeLimit { get; set; }

    [BinaryContent(Name = "ShowScrollHintWhenOffscreen", NodeType = BinaryContentTypes.Attribute)]
    public object ShowScrollHintWhenOffscreen { get; set; }

    [BinaryContent(Name = "HintDisplayTime", NodeType = BinaryContentTypes.Attribute)]
    public object HintDisplayTime { get; set; }

    [BinaryContent(Name = "HintText", NodeType = BinaryContentTypes.Attribute)]
    public object HintText { get; set; }

    [BinaryContent(Name = "UseSpecificPortrait", NodeType = BinaryContentTypes.Attribute)]
    public object UseSpecificPortrait { get; set; }

    [BinaryContent(Name = "SpecificPortraitProfile", NodeType = BinaryContentTypes.Attribute)]
    public object SpecificPortraitProfile { get; set; }

    [BinaryContent(Name = "RegisterTimestamp", NodeType = BinaryContentTypes.Attribute)]
    public object RegisterTimestamp { get; set; }

    [BinaryContent(Name = "IsAllowedAsRootCondition", NodeType = BinaryContentTypes.Attribute)]
    public object IsAllowedAsRootCondition { get; set; }

    [BinaryContent(Name = "CounterScopeUseCurrentContext", NodeType = BinaryContentTypes.Attribute)]
    public object CounterScopeUseCurrentContext { get; set; }

    [BinaryContent(Name = "CounterScopeKeepFirstFound", NodeType = BinaryContentTypes.Attribute)]
    public object CounterScopeKeepFirstFound { get; set; }

    [BinaryContent(Name = "StartingAmountSet", NodeType = BinaryContentTypes.Attribute)]
    public object StartingAmountSet { get; set; }

    [BinaryContent(Name = "ConditionQuestStateStates", NodeType = BinaryContentTypes.Attribute)]
    public object ConditionQuestStateStates { get; set; }

    [BinaryContent(Name = "ConditionQuestStateQuestGUID", NodeType = BinaryContentTypes.Attribute)]
    public object ConditionQuestStateQuestGUID { get; set; }

    [BinaryContent(Name = "CounterScopeUseActiveSession", NodeType = BinaryContentTypes.Attribute)]
    public object CounterScopeUseActiveSession { get; set; }

    [BinaryContent(Name = "SessionGUID", NodeType = BinaryContentTypes.Attribute)]
    public object SessionGUID { get; set; }

    [BinaryContent(Name = "UseActiveSession", NodeType = BinaryContentTypes.Attribute)]
    public object UseActiveSession { get; set; }

    [BinaryContent(Name = "NegativeOffsetAmount", NodeType = BinaryContentTypes.Attribute)]
    public object NegativeOffsetAmount { get; set; }

    [BinaryContent(Name = "ModulePercentage", NodeType = BinaryContentTypes.Attribute)]
    public object ModulePercentage { get; set; }

    [BinaryContent(Name = "TargetIDs", NodeType = BinaryContentTypes.Attribute)]
    public object TargetIDs { get; set; }

    [BinaryContent(Name = "IsOptional", NodeType = BinaryContentTypes.Attribute)]
    public object IsOptional { get; set; }

    [BinaryContent(Name = "ContextGUID", NodeType = BinaryContentTypes.Attribute)]
    public object ContextGUID { get; set; }

    [BinaryContent(Name = "ObjectiveQuestTrackerVisibility", NodeType = BinaryContentTypes.Attribute)]
    public object ObjectiveQuestTrackerVisibility { get; set; }

    [BinaryContent(Name = "SpawnObjectSettingsIndex", NodeType = BinaryContentTypes.Attribute)]
    public object SpawnObjectSettingsIndex { get; set; }

    [BinaryContent(Name = "LastCollectorID", NodeType = BinaryContentTypes.Attribute)]
    public object LastCollectorID { get; set; }

    [BinaryContent(Name = "Range", NodeType = BinaryContentTypes.Attribute)]
    public object Range { get; set; }

    [BinaryContent(Name = "TargetObject_sir", NodeType = BinaryContentTypes.Attribute)]
    public object TargetObject_sir { get; set; }

    [BinaryContent(Name = "CheckSpecificShipOwner", NodeType = BinaryContentTypes.Attribute)]
    public object CheckSpecificShipOwner { get; set; }

    [BinaryContent(Name = "TargetObjects", NodeType = BinaryContentTypes.Attribute)]
    public object TargetObjectsAttribute { get; set; }

    [BinaryContent(Name = "AllowedLayers", NodeType = BinaryContentTypes.Attribute)]
    public object AllowedLayers { get; set; }

    [BinaryContent(Name = "TreasureItem", NodeType = BinaryContentTypes.Attribute)]
    public object TreasureItem { get; set; }

    [BinaryContent(Name = "AdditionalScrapItem", NodeType = BinaryContentTypes.Attribute)]
    public object AdditionalScrapItem { get; set; }

    [BinaryContent(Name = "SpawnedTreasureGround", NodeType = BinaryContentTypes.Attribute)]
    public object SpawnedTreasureGround { get; set; }

    [BinaryContent(Name = "OnlyShowOnQuestObjects", NodeType = BinaryContentTypes.Attribute)]
    public object OnlyShowOnQuestObjects { get; set; }

    [BinaryContent(Name = "StarterSettingsIndex", NodeType = BinaryContentTypes.Attribute)]
    public object StarterSettingsIndex { get; set; }

    [BinaryContent(Name = "DockingObjectDistance", NodeType = BinaryContentTypes.Attribute)]
    public object DockingObjectDistance { get; set; }

    [BinaryContent(Name = "HasExecutionPlace", NodeType = BinaryContentTypes.Attribute)]
    public object HasExecutionPlace { get; set; }

    [BinaryContent(Name = "StarterConditionKey", NodeType = BinaryContentTypes.Attribute)]
    public object StarterConditionKey { get; set; }

    [BinaryContent(Name = "SpawnAdditionalObjects", NodeType = BinaryContentTypes.Attribute)]
    public object SpawnAdditionalObjects { get; set; }

    [BinaryContent(Name = "AdditionalObjectDistanceToTreasure", NodeType = BinaryContentTypes.Attribute)]
    public object AdditionalObjectDistanceToTreasure { get; set; }

    [BinaryContent(Name = "TargetArea", NodeType = BinaryContentTypes.Attribute)]
    public object TargetArea { get; set; }

    [BinaryContent(Name = "AutoRemoveActionIndex", NodeType = BinaryContentTypes.Attribute)]
    public object AutoRemoveActionIndex { get; set; }

    [BinaryContent(Name = "ConfirmOnReach", NodeType = BinaryContentTypes.Attribute)]
    public object ConfirmOnReach { get; set; }

    [BinaryContent(Name = "DeliveryObjectSettingsIndex", NodeType = BinaryContentTypes.Attribute)]
    public object DeliveryObjectSettingsIndex { get; set; }

    [BinaryContent(Name = "AddScrapToTreasure", NodeType = BinaryContentTypes.Attribute)]
    public object AddScrapToTreasure { get; set; }

    [BinaryContent(Name = "RelativeToQuestStart", NodeType = BinaryContentTypes.Attribute)]
    public object RelativeToQuestStart { get; set; }

    [BinaryContent(Name = "ShowInvertedValues", NodeType = BinaryContentTypes.Attribute)]
    public object ShowInvertedValues { get; set; }

    [BinaryContent(Name = "ChildContextGUIDs", NodeType = BinaryContentTypes.Attribute)]
    public object ChildContextGUIDs { get; set; }

    [BinaryContent(Name = "ResetTimeLimit", NodeType = BinaryContentTypes.Attribute)]
    public object ResetTimeLimit { get; set; }

    [BinaryContent(Name = "SustainTime", NodeType = BinaryContentTypes.Attribute)]
    public object SustainTime { get; set; }

    [BinaryContent(Name = "ResetTimer", NodeType = BinaryContentTypes.Attribute)]
    public object ResetTimer { get; set; }

    [BinaryContent(Name = "ConfirmationSignsAndFeedbackIndex", NodeType = BinaryContentTypes.Attribute)]
    public object ConfirmationSignsAndFeedbackIndex { get; set; }

    [BinaryContent(Name = "IsNegated", NodeType = BinaryContentTypes.Attribute)]
    public object IsNegated { get; set; }

    [BinaryContent(Name = "IsBlacklist", NodeType = BinaryContentTypes.Attribute)]
    public object IsBlacklist { get; set; }

    [BinaryContent(Name = "IsTutorialResolved", NodeType = BinaryContentTypes.Attribute)]
    public object IsTutorialResolved { get; set; }

    [BinaryContent(Name = "Reputation", NodeType = BinaryContentTypes.Attribute)]
    public object Reputation { get; set; }

    [BinaryContent(Name = "ConditionQuestStateIsBlacklist", NodeType = BinaryContentTypes.Attribute)]
    public object ConditionQuestStateIsBlacklist { get; set; }

    [BinaryContent(Name = "RequiredLevel", NodeType = BinaryContentTypes.Attribute)]
    public object RequiredLevel { get; set; }

    [BinaryContent(Name = "UseProcessingParticipant_chl", NodeType = BinaryContentTypes.Attribute)]
    public object UseProcessingParticipant_chl { get; set; }

    [BinaryContent(Name = "PopulationLevel", NodeType = BinaryContentTypes.Attribute)]
    public object PopulationLevel { get; set; }

    [BinaryContent(Name = "ShipSession", NodeType = BinaryContentTypes.Attribute)]
    public object ShipSession { get; set; }

    [BinaryContent(Name = "ShipTarget", NodeType = BinaryContentTypes.Attribute)]
    public object ShipTarget { get; set; }

    [BinaryContent(Name = "ShipAmount", NodeType = BinaryContentTypes.Attribute)]
    public object ShipAmount { get; set; }

    [BinaryContent(Name = "TargetList", NodeType = BinaryContentTypes.Attribute)]
    public object TargetList { get; set; }

    [BinaryContent(Name = "CallAmountCurrent", NodeType = BinaryContentTypes.Attribute)]
    public object CallAmountCurrent { get; set; }

    [BinaryContent(Name = "ConditionFulfilled", NodeType = BinaryContentTypes.Attribute)]
    public object ConditionFulfilled { get; set; }

    [BinaryContent(Name = "SpecifyHintColorType", NodeType = BinaryContentTypes.Attribute)]
    public object SpecifyHintColorType { get; set; }

    [BinaryContent(Name = "SourceIsQuestOwner2", NodeType = BinaryContentTypes.Attribute)]
    public object SourceIsQuestOwner2 { get; set; }

    [BinaryContent(Name = "NeededGUIDList", NodeType = BinaryContentTypes.Attribute)]
    public object NeededGUIDList { get; set; }

    [BinaryContent(Name = "DLCAssetList", NodeType = BinaryContentTypes.Attribute)]
    public object DLCAssetList { get; set; }

    [BinaryContent(Name = "TradeRouteCount", NodeType = BinaryContentTypes.Attribute)]
    public object TradeRouteCount { get; set; }

    [BinaryContent(Name = "CurrentTradeRouteCount", NodeType = BinaryContentTypes.Attribute)]
    public object CurrentTradeRouteCount { get; set; }

    [BinaryContent(Name = "TargetItem", NodeType = BinaryContentTypes.Attribute)]
    public object TargetItem { get; set; }

    [BinaryContent(Name = "ItemAmount", NodeType = BinaryContentTypes.Attribute)]
    public object ItemAmount { get; set; }

    [BinaryContent(Name = "ItemTargetObject", NodeType = BinaryContentTypes.Attribute)]
    public object ItemTargetObject { get; set; }

    [BinaryContent(Name = "Difficulty", NodeType = BinaryContentTypes.Attribute)]
    public object Difficulty { get; set; }

    [BinaryContent(Name = "DifficultyConstructionCostRefund", NodeType = BinaryContentTypes.Attribute)]
    public object DifficultyConstructionCostRefund { get; set; }

    [BinaryContent(Name = "DifficultyLossCondition", NodeType = BinaryContentTypes.Attribute)]
    public object DifficultyLossCondition { get; set; }

    [BinaryContent(Name = "DifficultyOptionalQuestFrequency", NodeType = BinaryContentTypes.Attribute)]
    public object DifficultyOptionalQuestFrequency { get; set; }

    [BinaryContent(Name = "DifficultyOptionalQuestRewards", NodeType = BinaryContentTypes.Attribute)]
    public object DifficultyOptionalQuestRewards { get; set; }

    [BinaryContent(Name = "DifficultyRelocateBuildings", NodeType = BinaryContentTypes.Attribute)]
    public object DifficultyRelocateBuildings { get; set; }

    [BinaryContent(Name = "DifficultyRevenue", NodeType = BinaryContentTypes.Attribute)]
    public object DifficultyRevenue { get; set; }

    [BinaryContent(Name = "DifficultyStartCredits", NodeType = BinaryContentTypes.Attribute)]
    public object DifficultyStartCredits { get; set; }

    [BinaryContent(Name = "DifficultyStartShips", NodeType = BinaryContentTypes.Attribute)]
    public object DifficultyStartShips { get; set; }

    [BinaryContent(Name = "DifficultyStartWithKontor", NodeType = BinaryContentTypes.Attribute)]
    public object DifficultyStartWithKontor { get; set; }

    [BinaryContent(Name = "Data", NodeType = BinaryContentTypes.Attribute)]
    public object DataAttribute { get; set; }

    [BinaryContent(Name = "AllowResetTrigger", NodeType = BinaryContentTypes.Attribute)]
    public object AllowResetTrigger { get; set; }

    [BinaryContent(Name = "IgnoreTeamAlliance", NodeType = BinaryContentTypes.Attribute)]
    public object IgnoreTeamAlliance { get; set; }

    [BinaryContent(Name = "EventDataString", NodeType = BinaryContentTypes.Attribute)]
    public object EventDataString { get; set; }

    [BinaryContent(Name = "IsToolOneConfigured", NodeType = BinaryContentTypes.Attribute)]
    public object IsToolOneConfigured { get; set; }

    [BinaryContent(Name = "IsNetSafe", NodeType = BinaryContentTypes.Attribute)]
    public object IsNetSafe { get; set; }

    [BinaryContent(Name = "PageTargetViewCount", NodeType = BinaryContentTypes.Attribute)]
    public object PageTargetViewCount { get; set; }

    [BinaryContent(Name = "PageCurrentViewCount", NodeType = BinaryContentTypes.Attribute)]
    public object PageCurrentViewCount { get; set; }

    [BinaryContent(Name = "BurningObjectTargets", NodeType = BinaryContentTypes.Attribute)]
    public object BurningObjectTargets { get; set; }

    [BinaryContent(Name = "HumanPlayerCount", NodeType = BinaryContentTypes.Attribute)]
    public object HumanPlayerCount { get; set; }

    [BinaryContent(Name = "AllianceCount", NodeType = BinaryContentTypes.Attribute)]
    public object AllianceCount { get; set; }

    [BinaryContent(Name = "UseParentValues", NodeType = BinaryContentTypes.Attribute)]
    public object UseParentValues { get; set; }

    [BinaryContent(Name = "AreaFlags", NodeType = BinaryContentTypes.Attribute)]
    public object AreaFlags { get; set; }

    [BinaryContent(Name = "PresetAreaListValid", NodeType = BinaryContentTypes.Attribute)]
    public object PresetAreaListValid { get; set; }

    [BinaryContent(Name = "PresetAreaList", NodeType = BinaryContentTypes.Attribute)]
    public object PresetAreaList { get; set; }

    [BinaryContent(Name = "ContextAssetInfoLayer", NodeType = BinaryContentTypes.Attribute)]
    public object ContextAssetInfoLayer { get; set; }

    [BinaryContent(Name = "participantID", NodeType = BinaryContentTypes.Node)]
    public ConditionsListParticipantID ParticipantID { get; set; }

    [BinaryContent(Name = "conditionTypeEnum", NodeType = BinaryContentTypes.Node)]
    public ConditionTypeEnum ConditionTypeEnum { get; set; }

    [BinaryContent(Name = "PlayerCounter", NodeType = BinaryContentTypes.Node)]
    public ConditionsListPlayerCounter PlayerCounter { get; set; }

    [BinaryContent(Name = "ComparisonOp", NodeType = BinaryContentTypes.Node)]
    public ComparisonOp ComparisonOp { get; set; }

    [BinaryContent(Name = "CounterScope", NodeType = BinaryContentTypes.Node)]
    public CounterScope CounterScope { get; set; }

    [BinaryContent(Name = "CounterValueType", NodeType = BinaryContentTypes.Node)]
    public CounterValueType CounterValueType { get; set; }

    [BinaryContent(Name = "CheckedParticipant", NodeType = BinaryContentTypes.Node)]
    public CheckedParticipant CheckedParticipant { get; set; }

    [BinaryContent(Name = "AreaList", NodeType = BinaryContentTypes.Node)]
    public AreaList AreaList { get; set; }

    [BinaryContent(Name = "QuestGUID", NodeType = BinaryContentTypes.Node)]
    public QuestGUID QuestGUID { get; set; }

    [BinaryContent(Name = "ContextPool", NodeType = BinaryContentTypes.Node)]
    public ContextPool ContextPool { get; set; }

    [BinaryContent(Name = "Result", NodeType = BinaryContentTypes.Node)]
    public Result Result { get; set; }

    [BinaryContent(Name = "SubConditionCompletionOrder", NodeType = BinaryContentTypes.Node)]
    public SubConditionCompletionOrder SubConditionCompletionOrder { get; set; }

    [BinaryContent(Name = "QuestData", NodeType = BinaryContentTypes.Node)]
    public QuestData QuestData { get; set; }

    [BinaryContent(Name = "Actions", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActions Actions { get; set; }

    [BinaryContent(Name = "SubConditionKeys", NodeType = BinaryContentTypes.Node)]
    public SubConditionKeys SubConditionKeys { get; set; }

    [BinaryContent(Name = "ParticipantRelation", NodeType = BinaryContentTypes.Node)]
    public ParticipantRelation ParticipantRelation { get; set; }

    [BinaryContent(Name = "HintType", NodeType = BinaryContentTypes.Node)]
    public HintType HintType { get; set; }

    [BinaryContent(Name = "TutorialConditionType", NodeType = BinaryContentTypes.Node)]
    public TutorialConditionType TutorialConditionType { get; set; }

    [BinaryContent(Name = "HintEndCondition", NodeType = BinaryContentTypes.Node)]
    public HintEndCondition HintEndCondition { get; set; }

    [BinaryContent(Name = "HintAnchor", NodeType = BinaryContentTypes.Node)]
    public HintAnchor HintAnchor { get; set; }

    [BinaryContent(Name = "TutorialUiCategory", NodeType = BinaryContentTypes.Node)]
    public TutorialUiCategory TutorialUiCategory { get; set; }

    [BinaryContent(Name = "HintColorType", NodeType = BinaryContentTypes.Node)]
    public HintColorType HintColorType { get; set; }

    [BinaryContent(Name = "ObjectFilter", NodeType = BinaryContentTypes.Node)]
    public ConditionsListObjectFilter ObjectFilter { get; set; }

    [BinaryContent(Name = "HintGiverParticipantID", NodeType = BinaryContentTypes.Node)]
    public HintGiverParticipantID HintGiverParticipantID { get; set; }

    [BinaryContent(Name = "TutorialInteractionType", NodeType = BinaryContentTypes.Node)]
    public TutorialInteractionType TutorialInteractionType { get; set; }

    [BinaryContent(Name = "SpecificColorType", NodeType = BinaryContentTypes.Node)]
    public SpecificColorType SpecificColorType { get; set; }

    [BinaryContent(Name = "ConditionQuestStateRangeOp", NodeType = BinaryContentTypes.Node)]
    public ConditionQuestStateRangeOp ConditionQuestStateRangeOp { get; set; }

    [BinaryContent(Name = "ProductivityComparison", NodeType = BinaryContentTypes.Node)]
    public ProductivityComparison ProductivityComparison { get; set; }

    [BinaryContent(Name = "ModuleComparison", NodeType = BinaryContentTypes.Node)]
    public ModuleComparison ModuleComparison { get; set; }

    [BinaryContent(Name = "SelectingPeer", NodeType = BinaryContentTypes.Node)]
    public SelectingPeer SelectingPeer { get; set; }

    [BinaryContent(Name = "eventType", NodeType = BinaryContentTypes.Node)]
    public EventType EventType1 { get; set; }

    [BinaryContent(Name = "EventType", NodeType = BinaryContentTypes.Node)]
    public ConditionsListEventType EventType2 { get; set; }

    [BinaryContent(Name = "IterativeActions", NodeType = BinaryContentTypes.Node)]
    public IterativeActions IterativeActions { get; set; }

    [BinaryContent(Name = "Data", NodeType = BinaryContentTypes.Node)]
    public ConditionsListData DataNode { get; set; }

    [BinaryContent(Name = "SuccessorBaseQuestConditionKeys", NodeType = BinaryContentTypes.Node)]
    public SuccessorBaseQuestConditionKeys SuccessorBaseQuestConditionKeys { get; set; }

    [BinaryContent(Name = "MinimapFakePingIDs", NodeType = BinaryContentTypes.Node)]
    public MinimapFakePingIDs MinimapFakePingIDs { get; set; }

    [BinaryContent(Name = "ObjectSettings", NodeType = BinaryContentTypes.Node)]
    public ObjectSettings ObjectSettings { get; set; }

    [BinaryContent(Name = "FakePingObjectSettings", NodeType = BinaryContentTypes.Node)]
    public FakePingObjectSettings FakePingObjectSettings { get; set; }

    [BinaryContent(Name = "SpawnTypeInfo", NodeType = BinaryContentTypes.Node)]
    public SpawnTypeInfo SpawnTypeInfo { get; set; }

    [BinaryContent(Name = "TargetOwnerParticipant", NodeType = BinaryContentTypes.Node)]
    public TargetOwnerParticipant TargetOwnerParticipant { get; set; }

    [BinaryContent(Name = "ShipOwnerParticipant", NodeType = BinaryContentTypes.Node)]
    public ShipOwnerParticipant ShipOwnerParticipant { get; set; }

    [BinaryContent(Name = "ValidTargets", NodeType = BinaryContentTypes.Node)]
    public ValidTargets ValidTargets { get; set; }

    [BinaryContent(Name = "DivingBellObjectInfoList", NodeType = BinaryContentTypes.Node)]
    public DivingBellObjectInfoList DivingBellObjectInfoList { get; set; }

    [BinaryContent(Name = "ConditionResult", NodeType = BinaryContentTypes.Node)]
    public ConditionResult ConditionResult { get; set; }

    [BinaryContent(Name = "GoodsInRangeType", NodeType = BinaryContentTypes.Node)]
    public GoodsInRangeType GoodsInRangeType { get; set; }

    [BinaryContent(Name = "TargetObjects", NodeType = BinaryContentTypes.Node)]
    public ConditionsListTargetObjects TargetObjectsNode { get; set; }

    [BinaryContent(Name = "DemandedGoods", NodeType = BinaryContentTypes.Node)]
    public ConditionsListDemandedGoods DemandedGoods { get; set; }

    [BinaryContent(Name = "DeliveryType", NodeType = BinaryContentTypes.Node)]
    public DeliveryType DeliveryType { get; set; }

    [BinaryContent(Name = "ComparisonOperator", NodeType = BinaryContentTypes.Node)]
    public ComparisonOperator ComparisonOperator { get; set; }

    [BinaryContent(Name = "SourceParticipant2", NodeType = BinaryContentTypes.Node)]
    public SourceParticipant2 SourceParticipant2 { get; set; }

    [BinaryContent(Name = "TargetParticipant2", NodeType = BinaryContentTypes.Node)]
    public TargetParticipant2 TargetParticipant2 { get; set; }

    [BinaryContent(Name = "DesiredState", NodeType = BinaryContentTypes.Node)]
    public DesiredState DesiredState { get; set; }

    [BinaryContent(Name = "Participant_chl", NodeType = BinaryContentTypes.Node)]
    public Participant_chl Participant_chl { get; set; }

    [BinaryContent(Name = "RequiredHappinessRanges", NodeType = BinaryContentTypes.Node)]
    public RequiredHappinessRanges RequiredHappinessRanges { get; set; }

    [BinaryContent(Name = "ShipComparison", NodeType = BinaryContentTypes.Node)]
    public ShipComparison ShipComparison { get; set; }

    [BinaryContent(Name = "ShipOwner", NodeType = BinaryContentTypes.Node)]
    public ShipOwner ShipOwner { get; set; }

    [BinaryContent(Name = "WinLoseState", NodeType = BinaryContentTypes.Node)]
    public WinLoseState WinLoseState { get; set; }

    [BinaryContent(Name = "GUIState", NodeType = BinaryContentTypes.Node)]
    public GUIState GUIState { get; set; }

    [BinaryContent(Name = "InGameParticipant", NodeType = BinaryContentTypes.Node)]
    public InGameParticipant InGameParticipant { get; set; }

    #endregion Public Properties
  }
}