using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class StartQuestData {

[BinaryContent(Name = "QuestLineGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString QuestLineGUID { get; set; }

[BinaryContent(Name = "MetaData", NodeType = BinaryContentTypes.Node)]
public MetaData MetaData { get; set; }

[BinaryContent(Name = "TriggeringChain", NodeType = BinaryContentTypes.Attribute)]
public HexString TriggeringChain { get; set; }

}
}
