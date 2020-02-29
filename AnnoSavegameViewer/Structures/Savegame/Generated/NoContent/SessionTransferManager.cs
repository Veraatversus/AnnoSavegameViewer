using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SessionTransferManager {

    [BinaryContent(Name = "IDManager", NodeType = BinaryContentTypes.Node)]
    public SessionTransferManagerIDManager IDManager { get; set; }

    [BinaryContent(Name = "QueuedTransfers", NodeType = BinaryContentTypes.Node)]
    public QueuedTransfers QueuedTransfers { get; set; }

  }
}