using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class TextInfoList {

    [BinaryContent(Name = "type", NodeType = BinaryContentTypes.Attribute)]
    public object Type { get; set; }

    [BinaryContent(Name = "valArea", NodeType = BinaryContentTypes.Attribute)]
    public object ValArea { get; set; }

    [BinaryContent(Name = "valObj", NodeType = BinaryContentTypes.Node)]
    public ValObj ValObj { get; set; }

  }
}