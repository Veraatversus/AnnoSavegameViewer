using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PassiveTradeEntriesList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public PassiveTradeEntriesListValue Value { get; set; }

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<PassiveTradeEntriesListList> PassiveTradeEntriesListList { get; set; }

  }
}