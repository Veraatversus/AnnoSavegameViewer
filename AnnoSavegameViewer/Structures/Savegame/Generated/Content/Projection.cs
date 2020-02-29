using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Projection {

    [BinaryContent(Name = "Flags", NodeType = BinaryContentTypes.Attribute)]
    public object Flags { get; set; }

    [BinaryContent(Name = "NearClip", NodeType = BinaryContentTypes.Attribute)]
    public object NearClip { get; set; }

  }
}