using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaRandomManager {

    [BinaryContent(Name = "netsafeRandom", NodeType = BinaryContentTypes.Node)]
    public NetsafeRandom NetsafeRandom { get; set; }

  }
}