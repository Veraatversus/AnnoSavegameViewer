using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Selection {

    [BinaryContent(Name = "Detected", NodeType = BinaryContentTypes.Attribute)]
    public object Detected { get; set; }

  }
}