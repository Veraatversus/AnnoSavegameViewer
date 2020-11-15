using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ItemMapValue {

[BinaryContent(Name = "ItemID", NodeType = BinaryContentTypes.Attribute)]
public HexString ItemID { get; set; }

[BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
public HexString GUID { get; set; }

[BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Attribute)]
public HexString QuestID { get; set; }

[BinaryContent(Name = "Charges", NodeType = BinaryContentTypes.Attribute)]
public HexString Charges { get; set; }

}
}
