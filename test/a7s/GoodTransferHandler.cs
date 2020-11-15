using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class GoodTransferHandler {

[BinaryContent(Name = "activeTransfers", NodeType = BinaryContentTypes.Node)]
public ActiveTransfers ActiveTransfers { get; set; }

}
}
