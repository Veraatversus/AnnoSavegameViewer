using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PlayerCounter {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public Value Value { get; set; }

  }
}