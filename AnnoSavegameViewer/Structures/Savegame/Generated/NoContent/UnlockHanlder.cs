using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class UnlockHanlder {

    [BinaryContent(Name = "Requirements", NodeType = BinaryContentTypes.Node)]
    public Requirements Requirements { get; set; }

  }
}