namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class GlobalCounter {

    [BinaryContent(Name = "Counters", NodeType = BinaryContentTypes.Node)]
    public GlobalCounterCounters Counters { get; set; }

  }
}