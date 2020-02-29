using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Random {

    [BinaryContent(Name = "P1", NodeType = BinaryContentTypes.Attribute)]
    public object P1 { get; set; }

    [BinaryContent(Name = "P2", NodeType = BinaryContentTypes.Attribute)]
    public object P2 { get; set; }

    [BinaryContent(Name = "Buffer", NodeType = BinaryContentTypes.Attribute)]
    public object Buffer { get; set; }

    [BinaryContent(Name = "Counter", NodeType = BinaryContentTypes.Attribute)]
    public object Counter { get; set; }

  }
}