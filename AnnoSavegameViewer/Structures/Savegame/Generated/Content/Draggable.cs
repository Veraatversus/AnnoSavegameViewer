using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Draggable {

    [BinaryContent(Name = "Dragger", NodeType = BinaryContentTypes.Attribute)]
    public object Dragger { get; set; }

  }
}