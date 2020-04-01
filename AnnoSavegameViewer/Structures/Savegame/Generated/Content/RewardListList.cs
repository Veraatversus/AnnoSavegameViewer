using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class RewardListList {

    [BinaryContent(Name = "Amount", NodeType = BinaryContentTypes.Attribute)]
    public object Amount { get; set; }

    [BinaryContent(Name = "AssetGUID", NodeType = BinaryContentTypes.Attribute)]
    public object AssetGUID { get; set; }

    [BinaryContent(Name = "SentToQuestArea", NodeType = BinaryContentTypes.Attribute)]
    public object SentToQuestArea { get; set; }

    [BinaryContent(Name = "IsDisguised", NodeType = BinaryContentTypes.Attribute)]
    public object IsDisguised { get; set; }

  }
}