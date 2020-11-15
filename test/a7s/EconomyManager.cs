using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class EconomyManager {

[BinaryContent(Name = "MetaStorageCount", NodeType = BinaryContentTypes.Attribute)]
public HexString MetaStorageCount { get; set; }

[BinaryContent(Name = "Pair", NodeType = BinaryContentTypes.Node)]
public Pair Pair { get; set; }

}
}
