using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CurrentTradeStatusList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public CurrentTradeStatusListValue Value { get; set; }

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<CurrentTradeStatusListList> CurrentTradeStatusListList { get; set; }

  }
}