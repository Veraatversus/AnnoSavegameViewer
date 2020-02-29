using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ShareValueFluctuation {

    [BinaryContent(Name = "Fluctuating", NodeType = BinaryContentTypes.Attribute)]
    public object Fluctuating { get; set; }

    [BinaryContent(Name = "NextChange", NodeType = BinaryContentTypes.Attribute)]
    public object NextChange { get; set; }

    [BinaryContent(Name = "Velocity", NodeType = BinaryContentTypes.Attribute)]
    public object Velocity { get; set; }

    [BinaryContent(Name = "Offset", NodeType = BinaryContentTypes.Attribute)]
    public object Offset { get; set; }

  }
}