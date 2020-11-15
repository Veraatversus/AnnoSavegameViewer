using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class SessionTransferManager {

[BinaryContent(Name = "IDManager", NodeType = BinaryContentTypes.Node)]
public SessionTransferManagerIDManager IDManager { get; set; }

[BinaryContent(Name = "QueuedTransfers", NodeType = BinaryContentTypes.Node)]
public QueuedTransfers QueuedTransfers { get; set; }

}
}
