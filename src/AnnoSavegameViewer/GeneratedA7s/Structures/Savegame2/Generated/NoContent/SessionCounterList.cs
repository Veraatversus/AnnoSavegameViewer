namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class SessionCounterList {

    [BinaryContent(Name = "Counters", NodeType = BinaryContentTypes.Node)]
    public SessionCounterListCounters Counters { get; set; }

  }
}