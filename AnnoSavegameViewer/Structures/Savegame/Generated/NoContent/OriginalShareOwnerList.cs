using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class OriginalShareOwnerList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public OriginalShareOwnerListValue Value { get; set; }

  }
}