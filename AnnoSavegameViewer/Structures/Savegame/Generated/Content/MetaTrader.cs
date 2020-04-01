using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MetaTrader {

    [BinaryContent(Name = "ImperialKontorSession", NodeType = BinaryContentTypes.Attribute)]
    public object ImperialKontorSession { get; set; }

    [BinaryContent(Name = "ImperialKontorID", NodeType = BinaryContentTypes.Attribute)]
    public object ImperialKontorID { get; set; }

  }
}