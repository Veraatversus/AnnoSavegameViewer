using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Infolayer {

    [BinaryContent(Name = "Icons", NodeType = BinaryContentTypes.Node)]
    public Icons Icons { get; set; }

  }
}