using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class FakePingObjectSettingsValue {

[BinaryContent(Name = "ObjectGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString ObjectGUID { get; set; }

[BinaryContent(Name = "ExecutionPlace", NodeType = BinaryContentTypes.Attribute)]
public HexString ExecutionPlace { get; set; }

[BinaryContent(Name = "ScannerSpawnInfo", NodeType = BinaryContentTypes.Node)]
public ValuesNoneScannerSpawnInfo ScannerSpawnInfo { get; set; }

[BinaryContent(Name = "Objects", NodeType = BinaryContentTypes.Node)]
public NoneObjects Objects { get; set; }

[BinaryContent(Name = "SignsAndFeedbackSettings", NodeType = BinaryContentTypes.Node)]
public NoneSignsAndFeedbackSettings SignsAndFeedbackSettings { get; set; }

[BinaryContent(Name = "SpawnActionIndicies", NodeType = BinaryContentTypes.Attribute)]
public HexString SpawnActionIndicies { get; set; }

[BinaryContent(Name = "ObjectFilter", NodeType = BinaryContentTypes.Node)]
public ValuesNoneObjectFilter ObjectFilter { get; set; }

}
}
