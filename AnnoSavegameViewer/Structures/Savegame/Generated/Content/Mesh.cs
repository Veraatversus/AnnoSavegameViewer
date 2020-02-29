using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Mesh {

    [BinaryContent(Name = "DyeColorDetail", NodeType = BinaryContentTypes.Attribute)]
    public object DyeColorDetail { get; set; }

    [BinaryContent(Name = "Scale", NodeType = BinaryContentTypes.Attribute)]
    public object Scale { get; set; }

    [BinaryContent(Name = "Orientation", NodeType = BinaryContentTypes.Attribute)]
    public object Orientation { get; set; }

    [BinaryContent(Name = "DyeColor", NodeType = BinaryContentTypes.Attribute)]
    public object DyeColor { get; set; }

    [BinaryContent(Name = "Damage", NodeType = BinaryContentTypes.Attribute)]
    public object Damage { get; set; }

    [BinaryContent(Name = "Flags", NodeType = BinaryContentTypes.Node)]
    public Flags Flags { get; set; }

    [BinaryContent(Name = "SequenceData", NodeType = BinaryContentTypes.Node)]
    public SequenceData SequenceData { get; set; }

  }
}