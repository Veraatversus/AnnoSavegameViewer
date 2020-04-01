using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ItemMapList {

    [BinaryContent(Name = "ItemID", NodeType = BinaryContentTypes.Attribute)]
    public object ItemID { get; set; }

    [BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
    public object GUID { get; set; }

    [BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Attribute)]
    public object QuestID { get; set; }

    [BinaryContent(Name = "Charges", NodeType = BinaryContentTypes.Attribute)]
    public object Charges { get; set; }

  }
}