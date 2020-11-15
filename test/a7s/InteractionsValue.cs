using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class InteractionsValue {

[BinaryContent(Name = "AutoClose", NodeType = BinaryContentTypes.Attribute)]
public HexString AutoClose { get; set; }

[BinaryContent(Name = "IconGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString IconGUID { get; set; }

[BinaryContent(Name = "Callback", NodeType = BinaryContentTypes.Attribute)]
public HexString Callback { get; set; }

}
}
