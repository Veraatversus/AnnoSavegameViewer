using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class QuestMetaData {

[BinaryContent(Name = "QuestArea", NodeType = BinaryContentTypes.Attribute)]
public HexString QuestArea { get; set; }

[BinaryContent(Name = "RelatedQuestGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString RelatedQuestGUID { get; set; }

}
}
