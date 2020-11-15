namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class SessionRandomManager {

    [BinaryContent(Name = "NetworkSafeRandom", NodeType = BinaryContentTypes.Node)]
    public SessionRandomManagerNetworkSafeRandom NetworkSafeRandom { get; set; }

  }
}