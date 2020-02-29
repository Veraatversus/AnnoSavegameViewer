using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Other {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public OtherValue Value { get; set; }

  }
}