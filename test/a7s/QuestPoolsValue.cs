using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class QuestPoolsValue {

[BinaryContent(Name = "questPoolGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString QuestPoolGUID { get; set; }

[BinaryContent(Name = "OptionalCooldownTimestamp", NodeType = BinaryContentTypes.Node)]
public OptionalCooldownTimestamp OptionalCooldownTimestamp { get; set; }

[BinaryContent(Name = "QuestBlockings", NodeType = BinaryContentTypes.Node)]
public QuestBlockings QuestBlockings { get; set; }

[BinaryContent(Name = "IsEnabled", NodeType = BinaryContentTypes.Attribute)]
public HexString IsEnabled { get; set; }

}
}
