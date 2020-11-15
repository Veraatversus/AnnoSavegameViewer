namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class CountersList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<CountersListList> CountersListList { get; set; }

  }
}