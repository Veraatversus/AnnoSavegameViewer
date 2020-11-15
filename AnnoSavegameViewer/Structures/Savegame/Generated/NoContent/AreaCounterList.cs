namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class AreaCounterList {

    [BinaryContent(Name = "Counters", NodeType = BinaryContentTypes.Node)]
    public Counters Counters { get; set; }

  }
}