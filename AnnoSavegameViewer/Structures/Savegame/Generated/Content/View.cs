using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class View {

    [BinaryContent(Name = "From", NodeType = BinaryContentTypes.Attribute)]
    public object From { get; set; }

    [BinaryContent(Name = "Up", NodeType = BinaryContentTypes.Attribute)]
    public object Up { get; set; }

    [BinaryContent(Name = "Direction", NodeType = BinaryContentTypes.Attribute)]
    public object Direction { get; set; }

  }
}