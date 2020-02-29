using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class HaborType {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public HaborTypeValue Value { get; set; }

  }
}