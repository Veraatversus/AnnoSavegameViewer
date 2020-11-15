namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class QueuedTransfers {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<QueuedTransfersList> QueuedTransfersList { get; set; }

  }
}