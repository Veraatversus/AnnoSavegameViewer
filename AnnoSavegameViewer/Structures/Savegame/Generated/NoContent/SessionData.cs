using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SessionData {

    [BinaryContent(Name = "BinaryData", NodeType = BinaryContentTypes.Node)]
    public BinaryData BinaryData { get; set; }

  }
}