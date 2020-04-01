using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class UsedAmountList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public UsedAmountListValue Value { get; set; }

  }
}