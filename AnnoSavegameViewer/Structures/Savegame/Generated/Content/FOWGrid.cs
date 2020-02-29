using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class FOWGrid {

    [BinaryContent(Name = "Width", NodeType = BinaryContentTypes.Attribute)]
    public object Width { get; set; }

    [BinaryContent(Name = "Height", NodeType = BinaryContentTypes.Attribute)]
    public object Height { get; set; }

    [BinaryContent(Name = "bits", NodeType = BinaryContentTypes.Attribute)]
    public object Bits { get; set; }

  }
}