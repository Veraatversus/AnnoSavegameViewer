using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class GoodTransferHandler {

    [BinaryContent(Name = "activeTransfers", NodeType = BinaryContentTypes.Node)]
    public ActiveTransfers ActiveTransfers { get; set; }

  }
}