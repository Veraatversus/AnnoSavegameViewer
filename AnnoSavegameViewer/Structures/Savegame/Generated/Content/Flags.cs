using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Flags {

    [BinaryContent(Name = "flags", NodeType = BinaryContentTypes.Attribute)]
    public object FlagsItem { get; set; }

  }
}