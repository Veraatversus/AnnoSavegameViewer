using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ObjectSettingsList {

    [BinaryContent(Name = "PropsObjectType", NodeType = BinaryContentTypes.Attribute)]
    public object PropsObjectType { get; set; }

    [BinaryContent(Name = "ExecutionPlace", NodeType = BinaryContentTypes.Attribute)]
    public object ExecutionPlace { get; set; }

    [BinaryContent(Name = "SpawnActionIndicies", NodeType = BinaryContentTypes.Attribute)]
    public object SpawnActionIndicies { get; set; }

    [BinaryContent(Name = "StarterConditionKey", NodeType = BinaryContentTypes.Attribute)]
    public object StarterConditionKey { get; set; }

    [BinaryContent(Name = "QuestGiver", NodeType = BinaryContentTypes.Attribute)]
    public object QuestGiver { get; set; }

    [BinaryContent(Name = "ScannerSpawnInfo", NodeType = BinaryContentTypes.Node)]
    public ObjectSettingsListScannerSpawnInfo ScannerSpawnInfo { get; set; }

    [BinaryContent(Name = "Objects", NodeType = BinaryContentTypes.Node)]
    public Objects Objects { get; set; }

    [BinaryContent(Name = "SignsAndFeedbackSettings", NodeType = BinaryContentTypes.Node)]
    public SignsAndFeedbackSettings SignsAndFeedbackSettings { get; set; }

    [BinaryContent(Name = "SpawnDescription", NodeType = BinaryContentTypes.Node)]
    public ObjectSettingsListSpawnDescription SpawnDescription { get; set; }

    [BinaryContent(Name = "SpawnObjectList", NodeType = BinaryContentTypes.Node)]
    public SpawnObjectList SpawnObjectList { get; set; }

    [BinaryContent(Name = "ObjectOwner", NodeType = BinaryContentTypes.Node)]
    public ObjectOwner ObjectOwner { get; set; }

    [BinaryContent(Name = "DespawnBehaviour", NodeType = BinaryContentTypes.Node)]
    public DespawnBehaviour DespawnBehaviour { get; set; }

    [BinaryContent(Name = "SpawnTiming", NodeType = BinaryContentTypes.Node)]
    public SpawnTiming SpawnTiming { get; set; }

    [BinaryContent(Name = "ObjectFilter", NodeType = BinaryContentTypes.Node)]
    public ObjectSettingsListObjectFilter ObjectFilter { get; set; }

  }
}