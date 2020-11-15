using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class History {

[BinaryContent(Name = "globalHistory", NodeType = BinaryContentTypes.Node)]
public GlobalHistory GlobalHistory { get; set; }

[BinaryContent(Name = "areaHistory", NodeType = BinaryContentTypes.Node)]
public AreaHistory AreaHistory { get; set; }

[BinaryContent(Name = "lastSnapshot", NodeType = BinaryContentTypes.Attribute)]
public HexString LastSnapshot { get; set; }

}
}
