namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class GameSessionsList {

    [BinaryContent(Name = "SessionDesc", NodeType = BinaryContentTypes.Node)]
    public SessionDesc SessionDesc { get; set; }

    [BinaryContent(Name = "SessionData", NodeType = BinaryContentTypes.Node)]
    public SessionData SessionData { get; set; }

  }
}