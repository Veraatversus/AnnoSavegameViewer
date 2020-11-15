using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class RewardGenerator {

[BinaryContent(Name = "RewardList", NodeType = BinaryContentTypes.Node)]
public RewardList RewardList { get; set; }

[BinaryContent(Name = "IsOptionalQuest", NodeType = BinaryContentTypes.Attribute)]
public HexString IsOptionalQuest { get; set; }

[BinaryContent(Name = "QuestDifficulty", NodeType = BinaryContentTypes.Node)]
public QuestDifficulty QuestDifficulty { get; set; }

[BinaryContent(Name = "ExpeditionDifficulty", NodeType = BinaryContentTypes.Node)]
public ExpeditionDifficulty ExpeditionDifficulty { get; set; }

[BinaryContent(Name = "ExpeditionRegion", NodeType = BinaryContentTypes.Node)]
public ExpeditionRegion ExpeditionRegion { get; set; }

}
}
