using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Interaction {

    [BinaryContent(Name = "Callback", NodeType = BinaryContentTypes.Attribute)]
    public object Callback { get; set; }

  }
}