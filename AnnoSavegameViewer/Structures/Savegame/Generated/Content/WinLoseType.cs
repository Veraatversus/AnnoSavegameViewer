using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class WinLoseType {

    [BinaryContent(Name = "WinLoseType", NodeType = BinaryContentTypes.Attribute)]
    public object WinLoseTypeItem { get; set; }

  }
}