using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class BezierPath {

    [BinaryContent(Name = "Path", NodeType = BinaryContentTypes.Node)]
    public Path Path { get; set; }

  }
}