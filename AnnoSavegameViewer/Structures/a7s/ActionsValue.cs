namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ActionsValue {

		[BinaryContent(Name = "actionType", NodeType = BinaryContentTypes.Node)]
		public NoneActionType ActionType { get; set; }

		[BinaryContent(Name = "Owner", NodeType = BinaryContentTypes.Node)]
		public ValuesNoneOwner Owner { get; set; }

		[BinaryContent(Name = "VisualSpawnOwner", NodeType = BinaryContentTypes.Node)]
		public VisualSpawnOwner VisualSpawnOwner { get; set; }

		[BinaryContent(Name = "OwnerParticipant", NodeType = BinaryContentTypes.Node)]
		public NoneOwnerParticipant OwnerParticipant { get; set; }

		[BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Attribute)]
		public HexString QuestID { get; set; }

		[BinaryContent(Name = "AssetGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString AssetGUID { get; set; }

		[BinaryContent(Name = "ActionID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ActionID { get; set; }

		[BinaryContent(Name = "TargetPeer", NodeType = BinaryContentTypes.Node)]
		public ActionsValuesNoneTargetPeer TargetPeer { get; set; }

		[BinaryContent(Name = "SpawnEntries", NodeType = BinaryContentTypes.Node)]
		public SpawnEntries SpawnEntries { get; set; }

		[BinaryContent(Name = "ParticipantID", NodeType = BinaryContentTypes.Node)]
		public ActionsValuesNoneParticipantID ParticipantID { get; set; }

		[BinaryContent(Name = "SpawnDescription", NodeType = BinaryContentTypes.Node)]
		public SpawnDescription SpawnDescription { get; set; }

		[BinaryContent(Name = "ScannerSpawnInfo", NodeType = BinaryContentTypes.Node)]
		public ScannerSpawnInfo ScannerSpawnInfo { get; set; }

		[BinaryContent(Name = "ScannerObjectID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ScannerObjectID { get; set; }

		[BinaryContent(Name = "SpawnedObjects", NodeType = BinaryContentTypes.Attribute)]
		public HexString SpawnedObjects { get; set; }

		[BinaryContent(Name = "SpawnedScanner", NodeType = BinaryContentTypes.Attribute)]
		public HexString SpawnedScanner { get; set; }

		[BinaryContent(Name = "SpawnedInSessionGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString SpawnedInSessionGUID { get; set; }

		[BinaryContent(Name = "SpawnContextPosition", NodeType = BinaryContentTypes.Attribute)]
		public HexString SpawnContextPosition { get; set; }

		[BinaryContent(Name = "SessionFilter", NodeType = BinaryContentTypes.Node)]
		public SessionFilter SessionFilter { get; set; }

		[BinaryContent(Name = "DemandedGoods", NodeType = BinaryContentTypes.Node)]
		public NoneDemandedGoods DemandedGoods { get; set; }

		[BinaryContent(Name = "TargetObjects", NodeType = BinaryContentTypes.Node)]
		public NoneTargetObjects TargetObjects { get; set; }

		[BinaryContent(Name = "TargetArea", NodeType = BinaryContentTypes.Attribute)]
		public HexString TargetArea { get; set; }

		[BinaryContent(Name = "SetMenuVisible", NodeType = BinaryContentTypes.Attribute)]
		public HexString SetMenuVisible { get; set; }

		[BinaryContent(Name = "MenuType", NodeType = BinaryContentTypes.Node)]
		public MenuType MenuType { get; set; }

		[BinaryContent(Name = "IsNetSafe", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsNetSafe { get; set; }

		[BinaryContent(Name = "SpawnGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString SpawnGUID { get; set; }

		[BinaryContent(Name = "Amount", NodeType = BinaryContentTypes.Attribute)]
		public HexString Amount { get; set; }

		[BinaryContent(Name = "CollectCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString CollectCount { get; set; }

		[BinaryContent(Name = "ConditionTutorialKey", NodeType = BinaryContentTypes.Attribute)]
		public HexString ConditionTutorialKey { get; set; }

		[BinaryContent(Name = "UnlockAssetGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString UnlockAssetGUID { get; set; }

		[BinaryContent(Name = "UnhideAssetGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString UnhideAssetGUID { get; set; }

		[BinaryContent(Name = "Variable", NodeType = BinaryContentTypes.Node)]
		public Variable Variable { get; set; }

		[BinaryContent(Name = "Modifier", NodeType = BinaryContentTypes.Node)]
		public Modifier Modifier { get; set; }

		[BinaryContent(Name = "ValueType", NodeType = BinaryContentTypes.Node)]
		public NoneValueType ValueType { get; set; }

		[BinaryContent(Name = "ModificationValue", NodeType = BinaryContentTypes.Attribute)]
		public HexString ModificationValue { get; set; }

		[BinaryContent(Name = "ClampVariableValue", NodeType = BinaryContentTypes.Attribute)]
		public HexString ClampVariableValue { get; set; }

		[BinaryContent(Name = "ClampValueMax", NodeType = BinaryContentTypes.Attribute)]
		public HexString ClampValueMax { get; set; }

		[BinaryContent(Name = "VariableValue", NodeType = BinaryContentTypes.Node)]
		public VariableValue VariableValue { get; set; }

		[BinaryContent(Name = "ActionListSuccess", NodeType = BinaryContentTypes.Node)]
		public ActionListSuccess ActionListSuccess { get; set; }

		[BinaryContent(Name = "ActionListFailure", NodeType = BinaryContentTypes.Node)]
		public ActionListFailure ActionListFailure { get; set; }

		[BinaryContent(Name = "TriggerAsset", NodeType = BinaryContentTypes.Attribute)]
		public HexString TriggerAsset { get; set; }

		[BinaryContent(Name = "NotificationType", NodeType = BinaryContentTypes.Node)]
		public NoneNotificationType NotificationType { get; set; }

		[BinaryContent(Name = "Notification", NodeType = BinaryContentTypes.Node)]
		public Notification Notification { get; set; }

		[BinaryContent(Name = "DelayVariable", NodeType = BinaryContentTypes.Node)]
		public NoneDelayVariable DelayVariable { get; set; }

		[BinaryContent(Name = "ExecutionDelay", NodeType = BinaryContentTypes.Attribute)]
		public HexString ExecutionDelay { get; set; }

		[BinaryContent(Name = "QuestMetaData", NodeType = BinaryContentTypes.Node)]
		public ValuesNoneQuestMetaData QuestMetaData { get; set; }

		[BinaryContent(Name = "DelayedActions", NodeType = BinaryContentTypes.Node)]
		public NoneDelayedActions DelayedActions { get; set; }

		[BinaryContent(Name = "Quest", NodeType = BinaryContentTypes.Attribute)]
		public HexString Quest { get; set; }

		[BinaryContent(Name = "ChangeForProcessingParticipant", NodeType = BinaryContentTypes.Attribute)]
		public HexString ChangeForProcessingParticipant { get; set; }

		[BinaryContent(Name = "SpecifyParticipant", NodeType = BinaryContentTypes.Node)]
		public SpecifyParticipant SpecifyParticipant { get; set; }

		[BinaryContent(Name = "QuestPoolListToChange", NodeType = BinaryContentTypes.Attribute)]
		public HexString QuestPoolListToChange { get; set; }

		[BinaryContent(Name = "UnregisterTrigger", NodeType = BinaryContentTypes.Attribute)]
		public HexString UnregisterTrigger { get; set; }

		[BinaryContent(Name = "QuestGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString QuestGUID { get; set; }

		[BinaryContent(Name = "WinQuest", NodeType = BinaryContentTypes.Attribute)]
		public HexString WinQuest { get; set; }

		[BinaryContent(Name = "PerformIntegrityCheck", NodeType = BinaryContentTypes.Attribute)]
		public HexString PerformIntegrityCheck { get; set; }

		[BinaryContent(Name = "ResetAssetGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ResetAssetGUID { get; set; }

		[BinaryContent(Name = "OpenNewspaperUI", NodeType = BinaryContentTypes.Attribute)]
		public HexString OpenNewspaperUI { get; set; }

		[BinaryContent(Name = "OpenNewspaperType", NodeType = BinaryContentTypes.Node)]
		public OpenNewspaperType OpenNewspaperType { get; set; }

		[BinaryContent(Name = "PamsyWelcomeRequiredAsset", NodeType = BinaryContentTypes.Attribute)]
		public HexString PamsyWelcomeRequiredAsset { get; set; }

		[BinaryContent(Name = "Articles", NodeType = BinaryContentTypes.Attribute)]
		public HexString Articles { get; set; }

		[BinaryContent(Name = "PictureArea", NodeType = BinaryContentTypes.Attribute)]
		public HexString PictureArea { get; set; }

	}
}
