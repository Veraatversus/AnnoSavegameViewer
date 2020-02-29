using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MetaProfileCounter {

    [BinaryContent(Name = "Stats", NodeType = BinaryContentTypes.Node)]
    public Stats Stats { get; set; }

  }
}