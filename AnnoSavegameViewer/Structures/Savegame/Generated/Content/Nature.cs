using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Nature {

    [BinaryContent(Name = "objects", NodeType = BinaryContentTypes.Node)]
    public NatureObjects Objects { get; set; }

  }
}