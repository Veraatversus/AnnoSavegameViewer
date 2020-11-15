using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class IDManager {

[BinaryContent(Name = "FreeIDList", NodeType = BinaryContentTypes.Node)]
public FreeIDList FreeIDList { get; set; }

[BinaryContent(Name = "NextID", NodeType = BinaryContentTypes.Attribute)]
public HexString NextID { get; set; }

[BinaryContent(Name = "HotIDList", NodeType = BinaryContentTypes.Node)]
public HotIDList HotIDList { get; set; }

}
}
