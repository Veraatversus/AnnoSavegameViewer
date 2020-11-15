namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class Counters {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<CountersList> CountersList { get; set; }

  }
}