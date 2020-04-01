using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class FakePingObjectSettingsList {

    [BinaryContent(Name = "ObjectGUID", NodeType = BinaryContentTypes.Attribute)]
    public object ObjectGUID { get; set; }

    [BinaryContent(Name = "ExecutionPlace", NodeType = BinaryContentTypes.Attribute)]
    public object ExecutionPlace { get; set; }

    [BinaryContent(Name = "SpawnActionIndicies", NodeType = BinaryContentTypes.Attribute)]
    public object SpawnActionIndicies { get; set; }

    [BinaryContent(Name = "ScannerSpawnInfo", NodeType = BinaryContentTypes.Node)]
    public FakePingObjectSettingsListScannerSpawnInfo ScannerSpawnInfo { get; set; }

    [BinaryContent(Name = "Objects", NodeType = BinaryContentTypes.Node)]
    public FakePingObjectSettingsListObjects Objects { get; set; }

    [BinaryContent(Name = "SignsAndFeedbackSettings", NodeType = BinaryContentTypes.Node)]
    public FakePingObjectSettingsListSignsAndFeedbackSettings SignsAndFeedbackSettings { get; set; }

    [BinaryContent(Name = "ObjectFilter", NodeType = BinaryContentTypes.Node)]
    public FakePingObjectSettingsListObjectFilter ObjectFilter { get; set; }

  }
}