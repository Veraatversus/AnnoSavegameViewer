using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CountersList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<CountersListList> CountersListList { get; set; }

  }
}