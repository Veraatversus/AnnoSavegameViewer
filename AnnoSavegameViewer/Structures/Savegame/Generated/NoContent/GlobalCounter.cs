using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class GlobalCounter {

    [BinaryContent(Name = "Counters", NodeType = BinaryContentTypes.Node)]
    public GlobalCounterCounters Counters { get; set; }

  }
}