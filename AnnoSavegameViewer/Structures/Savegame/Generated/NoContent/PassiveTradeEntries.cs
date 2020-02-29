using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PassiveTradeEntries {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<PassiveTradeEntriesList> PassiveTradeEntriesList { get; set; }

  }
}