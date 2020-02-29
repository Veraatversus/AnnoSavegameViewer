using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CurrentTradeStatus {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<CurrentTradeStatusList> CurrentTradeStatusList { get; set; }

  }
}