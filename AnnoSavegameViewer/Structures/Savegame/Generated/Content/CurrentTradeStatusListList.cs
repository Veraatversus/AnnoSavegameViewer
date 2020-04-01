using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CurrentTradeStatusListList {

    [BinaryContent(Name = "Step", NodeType = BinaryContentTypes.Attribute)]
    public object Step { get; set; }

    [BinaryContent(Name = "CurrentAmount", NodeType = BinaryContentTypes.Attribute)]
    public object CurrentAmount { get; set; }

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public CurrentTradeStatusListListValue Value { get; set; }

  }
}