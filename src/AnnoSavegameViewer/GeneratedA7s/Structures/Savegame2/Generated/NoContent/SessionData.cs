namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class SessionData {

    [BinaryContent(Name = "BinaryData", NodeType = BinaryContentTypes.Node)]
    public BinaryData BinaryData { get; set; }

  }
}