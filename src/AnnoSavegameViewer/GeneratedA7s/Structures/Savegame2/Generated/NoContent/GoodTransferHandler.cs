namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class GoodTransferHandler {

    [BinaryContent(Name = "activeTransfers", NodeType = BinaryContentTypes.Node)]
    public ActiveTransfers ActiveTransfers { get; set; }

  }
}