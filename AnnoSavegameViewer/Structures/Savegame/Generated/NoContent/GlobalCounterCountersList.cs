using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class GlobalCounterCountersList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<GlobalCounterCountersListList> GlobalCounterCountersListList { get; set; }

  }
}