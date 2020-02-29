using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class UnlockHanlder {

    [BinaryContent(Name = "Requirements", NodeType = BinaryContentTypes.Node)]
    public Requirements Requirements { get; set; }

  }
}