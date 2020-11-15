using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class NoneDemandedGoodsValue {

[BinaryContent(Name = "ProductGuid", NodeType = BinaryContentTypes.Attribute)]
public HexString ProductGuid { get; set; }

[BinaryContent(Name = "ProductAmount", NodeType = BinaryContentTypes.Attribute)]
public HexString ProductAmount { get; set; }

[BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Node)]
public ValuesNoneQuestID QuestID { get; set; }

}
}
