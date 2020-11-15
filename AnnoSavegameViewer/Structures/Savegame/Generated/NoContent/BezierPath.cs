namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class BezierPath {

    [BinaryContent(Name = "Path", NodeType = BinaryContentTypes.Node)]
    public Path Path { get; set; }

  }
}