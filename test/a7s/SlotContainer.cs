using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class SlotContainer {

[BinaryContent(Name = "SlotList", NodeType = BinaryContentTypes.Node)]
public SlotContainerSlotList SlotList { get; set; }

[BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
public HexString AreaID { get; set; }

[BinaryContent(Name = "UnlimitedSlotCount", NodeType = BinaryContentTypes.Attribute)]
public HexString UnlimitedSlotCount { get; set; }

[BinaryContent(Name = "UnlimitedStack", NodeType = BinaryContentTypes.Attribute)]
public HexString UnlimitedStack { get; set; }

}
}
