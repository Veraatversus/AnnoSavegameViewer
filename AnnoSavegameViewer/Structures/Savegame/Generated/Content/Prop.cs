using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Prop {

    [BinaryContent(Name = "Position", NodeType = BinaryContentTypes.Attribute)]
    public object Position { get; set; }

    [BinaryContent(Name = "Rotation", NodeType = BinaryContentTypes.Attribute)]
    public object Rotation { get; set; }

    [BinaryContent(Name = "Scale", NodeType = BinaryContentTypes.Attribute)]
    public object Scale { get; set; }

    [BinaryContent(Name = "Color", NodeType = BinaryContentTypes.Attribute)]
    public object Color { get; set; }

  }
}