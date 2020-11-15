using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ObjectSettingsValue {

[BinaryContent(Name = "PropsObjectType", NodeType = BinaryContentTypes.Attribute)]
public HexString PropsObjectType { get; set; }

[BinaryContent(Name = "ExecutionPlace", NodeType = BinaryContentTypes.Attribute)]
public HexString ExecutionPlace { get; set; }

[BinaryContent(Name = "ScannerSpawnInfo", NodeType = BinaryContentTypes.Node)]
public NoneScannerSpawnInfo ScannerSpawnInfo { get; set; }

[BinaryContent(Name = "Objects", NodeType = BinaryContentTypes.Node)]
public Objects Objects { get; set; }

[BinaryContent(Name = "SignsAndFeedbackSettings", NodeType = BinaryContentTypes.Node)]
public SignsAndFeedbackSettings SignsAndFeedbackSettings { get; set; }

[BinaryContent(Name = "SpawnActionIndicies", NodeType = BinaryContentTypes.Attribute)]
public HexString SpawnActionIndicies { get; set; }

[BinaryContent(Name = "SpawnDescription", NodeType = BinaryContentTypes.Node)]
public NoneSpawnDescription SpawnDescription { get; set; }

[BinaryContent(Name = "SpawnObjectList", NodeType = BinaryContentTypes.Node)]
public SpawnObjectList SpawnObjectList { get; set; }

[BinaryContent(Name = "ObjectOwner", NodeType = BinaryContentTypes.Node)]
public ObjectOwner ObjectOwner { get; set; }

[BinaryContent(Name = "DespawnBehaviour", NodeType = BinaryContentTypes.Node)]
public DespawnBehaviour DespawnBehaviour { get; set; }

[BinaryContent(Name = "SpawnTiming", NodeType = BinaryContentTypes.Node)]
public SpawnTiming SpawnTiming { get; set; }

[BinaryContent(Name = "ObjectFilter", NodeType = BinaryContentTypes.Node)]
public NoneObjectFilter ObjectFilter { get; set; }

[BinaryContent(Name = "QuestGiver", NodeType = BinaryContentTypes.Attribute)]
public HexString QuestGiver { get; set; }

[BinaryContent(Name = "ObjectGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString ObjectGUID { get; set; }

[BinaryContent(Name = "DespawnDelay", NodeType = BinaryContentTypes.Attribute)]
public HexString DespawnDelay { get; set; }

[BinaryContent(Name = "StarterConditionKey", NodeType = BinaryContentTypes.Attribute)]
public HexString StarterConditionKey { get; set; }

}
}
