using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Block_01 {

[BinaryContent(Name = "header.a7s", NodeType = BinaryContentTypes.Node, CompressionType = CompressionTypes.Zlib, ConversationType = ConversationTypes.FileDB, RdaFile = "header.a7s")]
public Header_a7s Header_a7s { get; set; }

}
}
