using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class HarborsListOwnerID {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public HarborsListOwnerIDValue Value { get; set; }

  }
}