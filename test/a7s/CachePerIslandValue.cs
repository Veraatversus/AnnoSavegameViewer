using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class CachePerIslandValue {

[BinaryContent(Name = "Ownage", NodeType = BinaryContentTypes.Attribute)]
public HexString Ownage { get; set; }

[BinaryContent(Name = "PreviousRejects", NodeType = BinaryContentTypes.Node)]
public PreviousRejects PreviousRejects { get; set; }

[BinaryContent(Name = "CoastErros", NodeType = BinaryContentTypes.Node)]
public CoastErros CoastErros { get; set; }

}
}
