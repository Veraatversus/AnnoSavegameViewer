using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class RewardListValue {

[BinaryContent(Name = "Amount", NodeType = BinaryContentTypes.Attribute)]
public HexString Amount { get; set; }

[BinaryContent(Name = "AssetGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString AssetGUID { get; set; }

[BinaryContent(Name = "SentToQuestArea", NodeType = BinaryContentTypes.Attribute)]
public HexString SentToQuestArea { get; set; }

[BinaryContent(Name = "IsDisguised", NodeType = BinaryContentTypes.Attribute)]
public HexString IsDisguised { get; set; }

}
}
