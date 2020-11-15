namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ConditionsValue {

		[BinaryContent(Name = "ConditionKey", NodeType = BinaryContentTypes.Attribute)]
		public HexString ConditionKey { get; set; }

		[BinaryContent(Name = "participantID", NodeType = BinaryContentTypes.Node)]
		public ValuesNoneParticipantID ParticipantID { get; set; }

		[BinaryContent(Name = "conditionTypeEnum", NodeType = BinaryContentTypes.Node)]
		public ConditionTypeEnum ConditionTypeEnum { get; set; }

		[BinaryContent(Name = "PlayerCounter", NodeType = BinaryContentTypes.Node)]
		public NonePlayerCounter PlayerCounter { get; set; }

		[BinaryContent(Name = "Context", NodeType = BinaryContentTypes.Attribute)]
		public HexString Context { get; set; }

		[BinaryContent(Name = "ComparisonOp", NodeType = BinaryContentTypes.Node)]
		public ComparisonOp ComparisonOp { get; set; }

		[BinaryContent(Name = "CounterAmount", NodeType = BinaryContentTypes.Attribute)]
		public HexString CounterAmount { get; set; }

		[BinaryContent(Name = "CounterScope", NodeType = BinaryContentTypes.Node)]
		public CounterScope CounterScope { get; set; }

		[BinaryContent(Name = "CounterScopeContext", NodeType = BinaryContentTypes.Attribute)]
		public HexString CounterScopeContext { get; set; }

		[BinaryContent(Name = "CounterValueType", NodeType = BinaryContentTypes.Node)]
		public CounterValueType CounterValueType { get; set; }

		[BinaryContent(Name = "CheckSpecificParticipant", NodeType = BinaryContentTypes.Attribute)]
		public HexString CheckSpecificParticipant { get; set; }

		[BinaryContent(Name = "CheckedParticipant", NodeType = BinaryContentTypes.Node)]
		public CheckedParticipant CheckedParticipant { get; set; }

		[BinaryContent(Name = "AreaList", NodeType = BinaryContentTypes.Node)]
		public AreaList AreaList { get; set; }

		[BinaryContent(Name = "QuestGUID", NodeType = BinaryContentTypes.Node)]
		public QuestGUID QuestGUID { get; set; }

		[BinaryContent(Name = "ContextPool", NodeType = BinaryContentTypes.Node)]
		public ContextPool ContextPool { get; set; }

		[BinaryContent(Name = "StartingAmountSet", NodeType = BinaryContentTypes.Attribute)]
		public HexString StartingAmountSet { get; set; }

		[BinaryContent(Name = "UniqueID", NodeType = BinaryContentTypes.Attribute)]
		public HexString UniqueID { get; set; }

		[BinaryContent(Name = "Result", NodeType = BinaryContentTypes.Node)]
		public Result Result { get; set; }

		[BinaryContent(Name = "AssetGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString AssetGUID { get; set; }

		[BinaryContent(Name = "SubConditionCompletionOrder", NodeType = BinaryContentTypes.Node)]
		public SubConditionCompletionOrder SubConditionCompletionOrder { get; set; }

		[BinaryContent(Name = "IsPermanent", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsPermanent { get; set; }

		[BinaryContent(Name = "UpdateManually", NodeType = BinaryContentTypes.Attribute)]
		public HexString UpdateManually { get; set; }

		[BinaryContent(Name = "Trigger", NodeType = BinaryContentTypes.Attribute)]
		public HexString Trigger { get; set; }

		[BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
		public HexString AreaID { get; set; }

		[BinaryContent(Name = "IsActive", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsActive { get; set; }

		[BinaryContent(Name = "QuestData", NodeType = BinaryContentTypes.Node)]
		public QuestData QuestData { get; set; }

		[BinaryContent(Name = "Actions", NodeType = BinaryContentTypes.Node)]
		public Actions Actions { get; set; }

		[BinaryContent(Name = "SubConditionKeys", NodeType = BinaryContentTypes.Node)]
		public SubConditionKeys SubConditionKeys { get; set; }

		[BinaryContent(Name = "UnlockNeeded", NodeType = BinaryContentTypes.Attribute)]
		public HexString UnlockNeeded { get; set; }

		[BinaryContent(Name = "IsResolved", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsResolved { get; set; }

		[BinaryContent(Name = "HintType", NodeType = BinaryContentTypes.Node)]
		public HintType HintType { get; set; }

		[BinaryContent(Name = "ShowScrollHintWhenOffscreen", NodeType = BinaryContentTypes.Attribute)]
		public HexString ShowScrollHintWhenOffscreen { get; set; }

		[BinaryContent(Name = "TutorialConditionType", NodeType = BinaryContentTypes.Node)]
		public TutorialConditionType TutorialConditionType { get; set; }

		[BinaryContent(Name = "HintEndCondition", NodeType = BinaryContentTypes.Node)]
		public HintEndCondition HintEndCondition { get; set; }

		[BinaryContent(Name = "HintDisplayTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString HintDisplayTime { get; set; }

		[BinaryContent(Name = "HintAnchor", NodeType = BinaryContentTypes.Node)]
		public HintAnchor HintAnchor { get; set; }

		[BinaryContent(Name = "HintText", NodeType = BinaryContentTypes.Attribute)]
		public HexString HintText { get; set; }

		[BinaryContent(Name = "TutorialUiCategory", NodeType = BinaryContentTypes.Node)]
		public TutorialUiCategory TutorialUiCategory { get; set; }

		[BinaryContent(Name = "UseSpecificPortrait", NodeType = BinaryContentTypes.Attribute)]
		public HexString UseSpecificPortrait { get; set; }

		[BinaryContent(Name = "SpecificPortraitProfile", NodeType = BinaryContentTypes.Attribute)]
		public HexString SpecificPortraitProfile { get; set; }

		[BinaryContent(Name = "HintColorType", NodeType = BinaryContentTypes.Node)]
		public HintColorType HintColorType { get; set; }

		[BinaryContent(Name = "RegisterTimestamp", NodeType = BinaryContentTypes.Attribute)]
		public HexString RegisterTimestamp { get; set; }

		[BinaryContent(Name = "ObjectFilter", NodeType = BinaryContentTypes.Node)]
		public ObjectFilter ObjectFilter { get; set; }

		[BinaryContent(Name = "HintGiverParticipantID", NodeType = BinaryContentTypes.Node)]
		public HintGiverParticipantID HintGiverParticipantID { get; set; }

		[BinaryContent(Name = "TutorialInteractionType", NodeType = BinaryContentTypes.Node)]
		public TutorialInteractionType TutorialInteractionType { get; set; }

		[BinaryContent(Name = "IsAllowedAsRootCondition", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsAllowedAsRootCondition { get; set; }

		[BinaryContent(Name = "SpecificColorType", NodeType = BinaryContentTypes.Node)]
		public SpecificColorType SpecificColorType { get; set; }

		[BinaryContent(Name = "IsTutorialResolved", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsTutorialResolved { get; set; }

		[BinaryContent(Name = "Reputation", NodeType = BinaryContentTypes.Attribute)]
		public HexString Reputation { get; set; }

		[BinaryContent(Name = "ComparisonOperator", NodeType = BinaryContentTypes.Node)]
		public ComparisonOperator ComparisonOperator { get; set; }

		[BinaryContent(Name = "IsNegated", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsNegated { get; set; }

		[BinaryContent(Name = "CounterScopeUseCurrentContext", NodeType = BinaryContentTypes.Attribute)]
		public HexString CounterScopeUseCurrentContext { get; set; }

		[BinaryContent(Name = "CounterScopeKeepFirstFound", NodeType = BinaryContentTypes.Attribute)]
		public HexString CounterScopeKeepFirstFound { get; set; }

		[BinaryContent(Name = "StartingAmount", NodeType = BinaryContentTypes.Attribute)]
		public HexString StartingAmount { get; set; }

		[BinaryContent(Name = "ConditionQuestStateStates", NodeType = BinaryContentTypes.Attribute)]
		public HexString ConditionQuestStateStates { get; set; }

		[BinaryContent(Name = "ConditionQuestStateQuestGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ConditionQuestStateQuestGUID { get; set; }

		[BinaryContent(Name = "ConditionQuestStateRangeOp", NodeType = BinaryContentTypes.Node)]
		public ConditionQuestStateRangeOp ConditionQuestStateRangeOp { get; set; }

		[BinaryContent(Name = "TimeLimit", NodeType = BinaryContentTypes.Attribute)]
		public HexString TimeLimit { get; set; }

		[BinaryContent(Name = "SpecifyHintColorType", NodeType = BinaryContentTypes.Attribute)]
		public HexString SpecifyHintColorType { get; set; }

		[BinaryContent(Name = "ModuleComparison", NodeType = BinaryContentTypes.Node)]
		public ModuleComparison ModuleComparison { get; set; }

		[BinaryContent(Name = "ModulePercentage", NodeType = BinaryContentTypes.Attribute)]
		public HexString ModulePercentage { get; set; }

		[BinaryContent(Name = "RequiredIndustrialization", NodeType = BinaryContentTypes.Node)]
		public RequiredIndustrialization RequiredIndustrialization { get; set; }

		[BinaryContent(Name = "CounterScopeUseActiveSession", NodeType = BinaryContentTypes.Attribute)]
		public HexString CounterScopeUseActiveSession { get; set; }

		[BinaryContent(Name = "eventType", NodeType = BinaryContentTypes.Node)]
		public EventType EventType { get; set; }

		[BinaryContent(Name = "EventType", NodeType = BinaryContentTypes.Node)]
		public NoneEventType EventType2 { get; set; }

		[BinaryContent(Name = "IsToolOneConfigured", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsToolOneConfigured { get; set; }

		[BinaryContent(Name = "IterativeActions", NodeType = BinaryContentTypes.Node)]
		public IterativeActions IterativeActions { get; set; }

		[BinaryContent(Name = "Data", NodeType = BinaryContentTypes.Attribute)]
		public HexString Data { get; set; }

		[BinaryContent(Name = "ProductivityComparison", NodeType = BinaryContentTypes.Node)]
		public ProductivityComparison ProductivityComparison { get; set; }

		[BinaryContent(Name = "EventDataString", NodeType = BinaryContentTypes.Attribute)]
		public HexString EventDataString { get; set; }

		[BinaryContent(Name = "CallAmountCurrent", NodeType = BinaryContentTypes.Attribute)]
		public HexString CallAmountCurrent { get; set; }

		[BinaryContent(Name = "ContextAssetInfoLayer", NodeType = BinaryContentTypes.Attribute)]
		public HexString ContextAssetInfoLayer { get; set; }

		[BinaryContent(Name = "ConditionFulfilled", NodeType = BinaryContentTypes.Attribute)]
		public HexString ConditionFulfilled { get; set; }

		[BinaryContent(Name = "Difficulty", NodeType = BinaryContentTypes.Attribute)]
		public HexString Difficulty { get; set; }

		[BinaryContent(Name = "DifficultyConstructionCostRefund", NodeType = BinaryContentTypes.Attribute)]
		public HexString DifficultyConstructionCostRefund { get; set; }

		[BinaryContent(Name = "DifficultyLossCondition", NodeType = BinaryContentTypes.Attribute)]
		public HexString DifficultyLossCondition { get; set; }

		[BinaryContent(Name = "DifficultyOptionalQuestFrequency", NodeType = BinaryContentTypes.Attribute)]
		public HexString DifficultyOptionalQuestFrequency { get; set; }

		[BinaryContent(Name = "DifficultyOptionalQuestRewards", NodeType = BinaryContentTypes.Attribute)]
		public HexString DifficultyOptionalQuestRewards { get; set; }

		[BinaryContent(Name = "DifficultyRelocateBuildings", NodeType = BinaryContentTypes.Attribute)]
		public HexString DifficultyRelocateBuildings { get; set; }

		[BinaryContent(Name = "DifficultyRevenue", NodeType = BinaryContentTypes.Attribute)]
		public HexString DifficultyRevenue { get; set; }

		[BinaryContent(Name = "DifficultyStartCredits", NodeType = BinaryContentTypes.Attribute)]
		public HexString DifficultyStartCredits { get; set; }

		[BinaryContent(Name = "DifficultyStartShips", NodeType = BinaryContentTypes.Attribute)]
		public HexString DifficultyStartShips { get; set; }

		[BinaryContent(Name = "DifficultyStartWithKontor", NodeType = BinaryContentTypes.Attribute)]
		public HexString DifficultyStartWithKontor { get; set; }

		[BinaryContent(Name = "SessionGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString SessionGUID { get; set; }

		[BinaryContent(Name = "UseActiveSession", NodeType = BinaryContentTypes.Attribute)]
		public HexString UseActiveSession { get; set; }

		[BinaryContent(Name = "ParticipantRelation", NodeType = BinaryContentTypes.Node)]
		public ParticipantRelation ParticipantRelation { get; set; }

		[BinaryContent(Name = "NegativeOffsetAmount", NodeType = BinaryContentTypes.Attribute)]
		public HexString NegativeOffsetAmount { get; set; }

		[BinaryContent(Name = "IsBlacklist", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsBlacklist { get; set; }

		[BinaryContent(Name = "TargetIDs", NodeType = BinaryContentTypes.Attribute)]
		public HexString TargetIDs { get; set; }

		[BinaryContent(Name = "SelectingPeer", NodeType = BinaryContentTypes.Node)]
		public SelectingPeer SelectingPeer { get; set; }

		[BinaryContent(Name = "IsOptional", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsOptional { get; set; }

		[BinaryContent(Name = "ContextGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ContextGUID { get; set; }

		[BinaryContent(Name = "CallAmount", NodeType = BinaryContentTypes.Attribute)]
		public HexString CallAmount { get; set; }

		[BinaryContent(Name = "SuccessorBaseQuestConditionKeys", NodeType = BinaryContentTypes.Node)]
		public SuccessorBaseQuestConditionKeys SuccessorBaseQuestConditionKeys { get; set; }

		[BinaryContent(Name = "ObjectiveQuestTrackerVisibility", NodeType = BinaryContentTypes.Attribute)]
		public HexString ObjectiveQuestTrackerVisibility { get; set; }

		[BinaryContent(Name = "MinimapFakePingIDs", NodeType = BinaryContentTypes.Node)]
		public MinimapFakePingIDs MinimapFakePingIDs { get; set; }

		[BinaryContent(Name = "HasExecutionPlace", NodeType = BinaryContentTypes.Attribute)]
		public HexString HasExecutionPlace { get; set; }

		[BinaryContent(Name = "ObjectSettings", NodeType = BinaryContentTypes.Node)]
		public ObjectSettings ObjectSettings { get; set; }

		[BinaryContent(Name = "FakePingObjectSettings", NodeType = BinaryContentTypes.Node)]
		public FakePingObjectSettings FakePingObjectSettings { get; set; }

		[BinaryContent(Name = "MoveAngleMin_cqd", NodeType = BinaryContentTypes.Attribute)]
		public HexString MoveAngleMin_cqd { get; set; }

		[BinaryContent(Name = "MoveAngleMax_cqd", NodeType = BinaryContentTypes.Attribute)]
		public HexString MoveAngleMax_cqd { get; set; }

		[BinaryContent(Name = "ObjectsBehaviour", NodeType = BinaryContentTypes.Node)]
		public ObjectsBehaviour ObjectsBehaviour { get; set; }

		[BinaryContent(Name = "AllowShipToCancelMovementToDefendItself", NodeType = BinaryContentTypes.Attribute)]
		public HexString AllowShipToCancelMovementToDefendItself { get; set; }

		[BinaryContent(Name = "SpawnObjectSettingsIndex", NodeType = BinaryContentTypes.Attribute)]
		public HexString SpawnObjectSettingsIndex { get; set; }

		[BinaryContent(Name = "PrebuiltObjectIndexList", NodeType = BinaryContentTypes.Attribute)]
		public HexString PrebuiltObjectIndexList { get; set; }

		[BinaryContent(Name = "DestroyEventPtrCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString DestroyEventPtrCount { get; set; }

		[BinaryContent(Name = "EscortSettingsIndex", NodeType = BinaryContentTypes.Attribute)]
		public HexString EscortSettingsIndex { get; set; }

		[BinaryContent(Name = "DestroySpawnInfo", NodeType = BinaryContentTypes.Node)]
		public DestroySpawnInfo DestroySpawnInfo { get; set; }

		[BinaryContent(Name = "TargetAngleOffset", NodeType = BinaryContentTypes.Attribute)]
		public HexString TargetAngleOffset { get; set; }

		[BinaryContent(Name = "GoodsInRangeType", NodeType = BinaryContentTypes.Node)]
		public GoodsInRangeType GoodsInRangeType { get; set; }

		[BinaryContent(Name = "TargetArea", NodeType = BinaryContentTypes.Attribute)]
		public HexString TargetArea { get; set; }

		[BinaryContent(Name = "TargetObjects", NodeType = BinaryContentTypes.Node)]
		public TargetObjects TargetObjects { get; set; }

		[BinaryContent(Name = "ValidTargets", NodeType = BinaryContentTypes.Node)]
		public ValidTargets ValidTargets { get; set; }

		[BinaryContent(Name = "DemandedGoods", NodeType = BinaryContentTypes.Node)]
		public DemandedGoods DemandedGoods { get; set; }

		[BinaryContent(Name = "AutoRemoveActionIndex", NodeType = BinaryContentTypes.Attribute)]
		public HexString AutoRemoveActionIndex { get; set; }

		[BinaryContent(Name = "AllowedLayers", NodeType = BinaryContentTypes.Attribute)]
		public HexString AllowedLayers { get; set; }

		[BinaryContent(Name = "DeliveryType", NodeType = BinaryContentTypes.Node)]
		public DeliveryType DeliveryType { get; set; }

		[BinaryContent(Name = "ConfirmOnReach", NodeType = BinaryContentTypes.Attribute)]
		public HexString ConfirmOnReach { get; set; }

		[BinaryContent(Name = "DeliveryObjectSettingsIndex", NodeType = BinaryContentTypes.Attribute)]
		public HexString DeliveryObjectSettingsIndex { get; set; }

		[BinaryContent(Name = "LastDestroyPos", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastDestroyPos { get; set; }

		[BinaryContent(Name = "TreasureItem", NodeType = BinaryContentTypes.Attribute)]
		public HexString TreasureItem { get; set; }

		[BinaryContent(Name = "SpawnedTreasureGround", NodeType = BinaryContentTypes.Attribute)]
		public HexString SpawnedTreasureGround { get; set; }

		[BinaryContent(Name = "DivingBellObjectInfoList", NodeType = BinaryContentTypes.Node)]
		public DivingBellObjectInfoList DivingBellObjectInfoList { get; set; }

		[BinaryContent(Name = "TargetOwnerParticipant", NodeType = BinaryContentTypes.Node)]
		public TargetOwnerParticipant TargetOwnerParticipant { get; set; }

		[BinaryContent(Name = "ShipOwnerParticipant", NodeType = BinaryContentTypes.Node)]
		public ShipOwnerParticipant ShipOwnerParticipant { get; set; }

		[BinaryContent(Name = "ConfirmationSignsAndFeedbackIndex", NodeType = BinaryContentTypes.Attribute)]
		public HexString ConfirmationSignsAndFeedbackIndex { get; set; }

		[BinaryContent(Name = "ConditionQuestStateIsBlacklist", NodeType = BinaryContentTypes.Attribute)]
		public HexString ConditionQuestStateIsBlacklist { get; set; }

		[BinaryContent(Name = "SourceParticipant2", NodeType = BinaryContentTypes.Node)]
		public SourceParticipant2 SourceParticipant2 { get; set; }

		[BinaryContent(Name = "TargetParticipant2", NodeType = BinaryContentTypes.Node)]
		public TargetParticipant2 TargetParticipant2 { get; set; }

		[BinaryContent(Name = "DesiredState", NodeType = BinaryContentTypes.Node)]
		public DesiredState DesiredState { get; set; }

		[BinaryContent(Name = "RequiredLevel", NodeType = BinaryContentTypes.Attribute)]
		public HexString RequiredLevel { get; set; }

		[BinaryContent(Name = "UseProcessingParticipant_chl", NodeType = BinaryContentTypes.Attribute)]
		public HexString UseProcessingParticipant_chl { get; set; }

		[BinaryContent(Name = "Participant_chl", NodeType = BinaryContentTypes.Node)]
		public Participant_chl Participant_chl { get; set; }

		[BinaryContent(Name = "PopulationLevel", NodeType = BinaryContentTypes.Attribute)]
		public HexString PopulationLevel { get; set; }

		[BinaryContent(Name = "RequiredHappinessRanges", NodeType = BinaryContentTypes.Node)]
		public RequiredHappinessRanges RequiredHappinessRanges { get; set; }

		[BinaryContent(Name = "ShipSession", NodeType = BinaryContentTypes.Attribute)]
		public HexString ShipSession { get; set; }

		[BinaryContent(Name = "ShipTarget", NodeType = BinaryContentTypes.Attribute)]
		public HexString ShipTarget { get; set; }

		[BinaryContent(Name = "ShipComparison", NodeType = BinaryContentTypes.Node)]
		public ShipComparison ShipComparison { get; set; }

		[BinaryContent(Name = "ShipAmount", NodeType = BinaryContentTypes.Attribute)]
		public HexString ShipAmount { get; set; }

		[BinaryContent(Name = "ShipOwner", NodeType = BinaryContentTypes.Node)]
		public ShipOwner ShipOwner { get; set; }

		[BinaryContent(Name = "TargetList", NodeType = BinaryContentTypes.Attribute)]
		public HexString TargetList { get; set; }

		[BinaryContent(Name = "ConditionResult", NodeType = BinaryContentTypes.Node)]
		public ConditionResult ConditionResult { get; set; }

		[BinaryContent(Name = "OnlyShowOnQuestObjects", NodeType = BinaryContentTypes.Attribute)]
		public HexString OnlyShowOnQuestObjects { get; set; }

		[BinaryContent(Name = "StarterSettingsIndex", NodeType = BinaryContentTypes.Attribute)]
		public HexString StarterSettingsIndex { get; set; }

		[BinaryContent(Name = "DockingObjectDistance", NodeType = BinaryContentTypes.Attribute)]
		public HexString DockingObjectDistance { get; set; }

		[BinaryContent(Name = "CircleAreaPercentage", NodeType = BinaryContentTypes.Attribute)]
		public HexString CircleAreaPercentage { get; set; }

		[BinaryContent(Name = "ScreenBorderPercentage", NodeType = BinaryContentTypes.Attribute)]
		public HexString ScreenBorderPercentage { get; set; }

		[BinaryContent(Name = "AppearInNewspaperArticle", NodeType = BinaryContentTypes.Attribute)]
		public HexString AppearInNewspaperArticle { get; set; }

		[BinaryContent(Name = "PhotographyObjects", NodeType = BinaryContentTypes.Attribute)]
		public HexString PhotographyObjects { get; set; }

		[BinaryContent(Name = "FinalObject", NodeType = BinaryContentTypes.Attribute)]
		public HexString FinalObject { get; set; }

		[BinaryContent(Name = "StarterConditionKey", NodeType = BinaryContentTypes.Attribute)]
		public HexString StarterConditionKey { get; set; }

		[BinaryContent(Name = "PhotographyObjectSettings", NodeType = BinaryContentTypes.Node)]
		public PhotographyObjectSettings PhotographyObjectSettings { get; set; }

		[BinaryContent(Name = "PhotographyObjectSettingsCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString PhotographyObjectSettingsCount { get; set; }

		[BinaryContent(Name = "SourceIsQuestOwner2", NodeType = BinaryContentTypes.Attribute)]
		public HexString SourceIsQuestOwner2 { get; set; }

		[BinaryContent(Name = "NeededGUIDList", NodeType = BinaryContentTypes.Attribute)]
		public HexString NeededGUIDList { get; set; }

		[BinaryContent(Name = "ChildContextGUIDs", NodeType = BinaryContentTypes.Attribute)]
		public HexString ChildContextGUIDs { get; set; }

		[BinaryContent(Name = "FakeQuestTrackerItemList", NodeType = BinaryContentTypes.Node)]
		public FakeQuestTrackerItemList FakeQuestTrackerItemList { get; set; }

		[BinaryContent(Name = "FakeDescriptionConditionListCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString FakeDescriptionConditionListCount { get; set; }

		[BinaryContent(Name = "UseQuestArea", NodeType = BinaryContentTypes.Attribute)]
		public HexString UseQuestArea { get; set; }

		[BinaryContent(Name = "DLCAssetList", NodeType = BinaryContentTypes.Attribute)]
		public HexString DLCAssetList { get; set; }

		[BinaryContent(Name = "Range", NodeType = BinaryContentTypes.Attribute)]
		public HexString Range { get; set; }

		[BinaryContent(Name = "TargetObject_sir", NodeType = BinaryContentTypes.Attribute)]
		public HexString TargetObject_sir { get; set; }

		[BinaryContent(Name = "CheckSpecificShipOwner", NodeType = BinaryContentTypes.Attribute)]
		public HexString CheckSpecificShipOwner { get; set; }

		[BinaryContent(Name = "ResetTimeLimit", NodeType = BinaryContentTypes.Attribute)]
		public HexString ResetTimeLimit { get; set; }

		[BinaryContent(Name = "SpawnTypeInfo", NodeType = BinaryContentTypes.Node)]
		public SpawnTypeInfo SpawnTypeInfo { get; set; }

		[BinaryContent(Name = "LastCollectorID", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastCollectorID { get; set; }

		[BinaryContent(Name = "CheckMinistryUnlocks", NodeType = BinaryContentTypes.Attribute)]
		public HexString CheckMinistryUnlocks { get; set; }

		[BinaryContent(Name = "DecreeFlags", NodeType = BinaryContentTypes.Node)]
		public DecreeFlags DecreeFlags { get; set; }

		[BinaryContent(Name = "AdditionalScrapItem", NodeType = BinaryContentTypes.Attribute)]
		public HexString AdditionalScrapItem { get; set; }

		[BinaryContent(Name = "AddScrapToTreasure", NodeType = BinaryContentTypes.Attribute)]
		public HexString AddScrapToTreasure { get; set; }

		[BinaryContent(Name = "Buff", NodeType = BinaryContentTypes.Attribute)]
		public HexString Buff { get; set; }

		[BinaryContent(Name = "RequiredAmount", NodeType = BinaryContentTypes.Attribute)]
		public HexString RequiredAmount { get; set; }

		[BinaryContent(Name = "ConditionHistoryList", NodeType = BinaryContentTypes.Node)]
		public ConditionHistoryList ConditionHistoryList { get; set; }

		[BinaryContent(Name = "VehicleDistance", NodeType = BinaryContentTypes.Attribute)]
		public HexString VehicleDistance { get; set; }

		[BinaryContent(Name = "ShowConfirmOnReach", NodeType = BinaryContentTypes.Attribute)]
		public HexString ShowConfirmOnReach { get; set; }

		[BinaryContent(Name = "PickupContextObjectSettingsIndex", NodeType = BinaryContentTypes.Attribute)]
		public HexString PickupContextObjectSettingsIndex { get; set; }

		[BinaryContent(Name = "CheckAdditionalModuleOnly", NodeType = BinaryContentTypes.Attribute)]
		public HexString CheckAdditionalModuleOnly { get; set; }

		[BinaryContent(Name = "TradeRouteCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString TradeRouteCount { get; set; }

		[BinaryContent(Name = "CurrentTradeRouteCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString CurrentTradeRouteCount { get; set; }

		[BinaryContent(Name = "WinLoseState", NodeType = BinaryContentTypes.Node)]
		public WinLoseState WinLoseState { get; set; }

		[BinaryContent(Name = "AllowResetTrigger", NodeType = BinaryContentTypes.Attribute)]
		public HexString AllowResetTrigger { get; set; }

		[BinaryContent(Name = "IgnoreTeamAlliance", NodeType = BinaryContentTypes.Attribute)]
		public HexString IgnoreTeamAlliance { get; set; }

		[BinaryContent(Name = "AffectedBuildingCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString AffectedBuildingCount { get; set; }

		[BinaryContent(Name = "AmountItemsEquipped", NodeType = BinaryContentTypes.Attribute)]
		public HexString AmountItemsEquipped { get; set; }

		[BinaryContent(Name = "BuildingWithEffectActive", NodeType = BinaryContentTypes.Node)]
		public BuildingWithEffectActive BuildingWithEffectActive { get; set; }

		[BinaryContent(Name = "AssetA", NodeType = BinaryContentTypes.Attribute)]
		public HexString AssetA { get; set; }

		[BinaryContent(Name = "AssetB", NodeType = BinaryContentTypes.Attribute)]
		public HexString AssetB { get; set; }

		[BinaryContent(Name = "CheckAbsoluteCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString CheckAbsoluteCount { get; set; }

		[BinaryContent(Name = "ModuleCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString ModuleCount { get; set; }

		[BinaryContent(Name = "RestrictToMandatoryModules", NodeType = BinaryContentTypes.Attribute)]
		public HexString RestrictToMandatoryModules { get; set; }

		[BinaryContent(Name = "Good_CP", NodeType = BinaryContentTypes.Attribute)]
		public HexString Good_CP { get; set; }

		[BinaryContent(Name = "ComparisonMode", NodeType = BinaryContentTypes.Node)]
		public ComparisonMode ComparisonMode { get; set; }

		[BinaryContent(Name = "CheckAbsoluteProduction", NodeType = BinaryContentTypes.Attribute)]
		public HexString CheckAbsoluteProduction { get; set; }

		[BinaryContent(Name = "ProductionRequired", NodeType = BinaryContentTypes.Attribute)]
		public HexString ProductionRequired { get; set; }

		[BinaryContent(Name = "PageTargetViewCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString PageTargetViewCount { get; set; }

		[BinaryContent(Name = "PageCurrentViewCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString PageCurrentViewCount { get; set; }

		[BinaryContent(Name = "BurningObjectTargets", NodeType = BinaryContentTypes.Attribute)]
		public HexString BurningObjectTargets { get; set; }

		[BinaryContent(Name = "HumanPlayerCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString HumanPlayerCount { get; set; }

		[BinaryContent(Name = "AllianceCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString AllianceCount { get; set; }

		[BinaryContent(Name = "IsNetSafe", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsNetSafe { get; set; }

		[BinaryContent(Name = "GUIState", NodeType = BinaryContentTypes.Node)]
		public GUIState GUIState { get; set; }

		[BinaryContent(Name = "UseParentValues", NodeType = BinaryContentTypes.Attribute)]
		public HexString UseParentValues { get; set; }

		[BinaryContent(Name = "AreaFlags", NodeType = BinaryContentTypes.Attribute)]
		public HexString AreaFlags { get; set; }

		[BinaryContent(Name = "PresetAreaListValid", NodeType = BinaryContentTypes.Attribute)]
		public HexString PresetAreaListValid { get; set; }

		[BinaryContent(Name = "PresetAreaList", NodeType = BinaryContentTypes.Attribute)]
		public HexString PresetAreaList { get; set; }

		[BinaryContent(Name = "InGameParticipant", NodeType = BinaryContentTypes.Node)]
		public InGameParticipant InGameParticipant { get; set; }

	}
}
