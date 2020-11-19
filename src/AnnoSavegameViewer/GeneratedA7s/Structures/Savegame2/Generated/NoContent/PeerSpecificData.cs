namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class PeerSpecificData {

    [BinaryContent(Name = "SessionData", NodeType = BinaryContentTypes.Node)]
    public PeerSpecificDataSessionData SessionData { get; set; }

  }
}